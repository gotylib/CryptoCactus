const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/chat")
    .build();

let intervalIdETH;

hubConnection.on("Receive", function (data) {
    document.getElementById('Bybit').innerText = data[0];
    document.getElementById('Okx').innerText = data[1];
    document.getElementById('HTX').innerText = data[2];
    document.getElementById('BitGet').innerText = data[3];
    document.getElementById('BingX').innerText = data[4];
    document.getElementById('Kucoin').innerText = data[5];
    document.getElementById('Huobi').innerText = data[6];
});

hubConnection.start()
    .then(function () {
        intervalIdETH = setInterval(() => {
            hubConnectionETH.invoke("Send", "ETH");
        }, 1000);
    })
    .catch(function (err) {
        return console.error(err.toString());
    });