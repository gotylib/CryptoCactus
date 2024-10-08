﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.CryproFactoryMethod
{
    public static class FactoryMethods
    {
        public static string FactoryMthodHtmlCryptoCurrency(string currency)
        {
            return $@"<!DOCTYPE html>
                    <html>
                    <head>
                        <link rel='stylesheet' href='tableStyle.css'>
                        <style>
                            .fade-in {{
                                opacity: 0; /* начальное значение непрозрачности */
                                animation: fadeIn ease-in 1; /* добавляем анимацию fadeIn */
                                animation-fill-mode: forwards; /* будет видимым после завершения анимации */
                                animation-duration: 1s; /* длительность анимации в 1 секунду */
                            }}

                            @keyframes fadeIn {{
                                0% {{
                                    opacity: 0;
                                }}

                                100% {{
                                    opacity: 1;
                                }}
                            }}
                        </style>

                    </head>
                    <body>
                        <h1 class='fade-in'><span class='blue'>&lt;</span>{currency}<span class='blue'>&gt;</span> <span class='yellow'>Price</span></h1>
                        <h2 class='fade-in'>Progect EVA</h2>

                        <table class='container'>
                            <thead>
                                <tr>
                                    <th><h1>Exchange</h1></th>
                                    <th><h1>Value</h1></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class='row'>
                                    <td>Bybit</td>
                                    <td id='Bybit'></td>
                                </tr>
                                <tr class='row'>
                                    <td>Okx</td>
                                    <td id='Okx'></td>
                                </tr>
                                <tr class='row'>
                                    <td>HTX</td>
                                    <td id='HTX'></td>
                                </tr>
                                <tr class='row'>
                                    <td>BingX</td>
                                    <td id='BingX'></td>
                                </tr>
                                <tr class='row'>
                                    <td>BitGet</td>
                                    <td id='BitGet'></td>
                                </tr>
                                <tr class='row'>
                                    <td>Kucoin</td>
                                    <td id='Kucoin'></td>
                                </tr>
                                <tr class='row'>
                                    <td>Huobi</td>
                                    <td id='Huobi'></td>
                                </tr>
                            </tbody>
                        </table>
                        <script src='https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/6.0.1/signalr.js'></script>
                        <script>
                            const hubConnection = new signalR.HubConnectionBuilder()
                                .withUrl('/chat')
                                .build();

                            let intervalIdETH;

                            hubConnection.on('Receive', function (data) {{
                                document.getElementById('Bybit').innerText = data[0];
                                document.getElementById('Okx').innerText = data[1];
                                document.getElementById('HTX').innerText = data[2];
                                document.getElementById('BingX').innerText = data[3];
                                document.getElementById('BitGet').innerText = data[4];
                                document.getElementById('Kucoin').innerText = data[5];
                                document.getElementById('Huobi').innerText = data[6];
                            }});

                            hubConnection.start()
                                .then(function () {{
                                    intervalIdETH = setInterval(() => {{
                                        hubConnection.invoke('Send', '{currency}');
                                    }}, 1000);
                                }})
                                .catch(function (err) {{
                                    return console.error(err.toString());
                                }});
                        </script>
                        <script>
                            // Получаем все строки таблицы
                            const rows = document.querySelectorAll('.row');

                            // Скрываем строки по умолчанию
                            rows.forEach(row => {{
                                row.style.opacity = 0;
                                row.style.transform = 'translateY(20px)';
                            }});

                            // Анимация появления строк с задержкой
                            let delay = 0;
                            rows.forEach(row => {{
                                setTimeout(() => {{
                                    row.style.opacity = 1;
                                    row.style.transform = 'translateY(0px)';
                                }}, delay);
                                delay += 200; // Задержка между строками
                            }});
                        </script>
                    </body>
                    </html>";
        }
    }
}
