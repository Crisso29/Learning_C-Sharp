/* Crisso es un desarrollador, él gana muy bien, pero la situación de
su país es tan crítica, más que nada en la política. Por el cual, él
quiere cambiar sus monedas a otra divisa. Por eso quiero que crees
un programa que entre a su tarjeta de crédito y 
muestre su saldo en su moneda local (juega con random), luego quiero que ese monto lo 
convierta a dólares, euros y libras, para ello, debes buscar en internet
la tasa de cambio (juega con random en un intervalo por ahora en vez de un API)*/

using System;

Random random= new();

decimal saldoTarjetaCrisso;
decimal tasaCambioDolar;
decimal tasaCambioEuro;
decimal tasaCambioLibra;

saldoTarjetaCrisso=(decimal)random.NextDouble()*(9300.75m-3200.50m)+3200.50m;
tasaCambioDolar=(decimal) random.NextDouble()*(3.60m-3.38m)+ 3.38m;
tasaCambioEuro= (decimal)random.NextDouble()*(4.40m-4.10m)+4.10m;
tasaCambioLibra=(decimal)random.NextDouble()*(4.90m-4.65m)+4.65m;

decimal saldoEnDolares=saldoTarjetaCrisso/tasaCambioDolar;
decimal saldoEnEuros=saldoTarjetaCrisso/tasaCambioEuro;
decimal saldoEnLibras=saldoTarjetaCrisso/tasaCambioLibra;

Console.WriteLine($"\t SALDO DISPONIBLE EN TU TARJETA: {saldoTarjetaCrisso:C2}");
Console.WriteLine($"Tu saldo en dólares sería: {saldoEnDolares:C2}");
Console.WriteLine($"Tu saldo en euros sería: {saldoEnEuros:C2}");
Console.WriteLine($"Tu saldo en libras sería: {saldoEnLibras:C2}");
Console.WriteLine($"\nTasa de cambio actual: --1 dólar = {tasaCambioDolar:C2}-- 1 euro = {tasaCambioEuro:C2}-- 1 libra = {tasaCambioLibra:C2}--");
Console.ReadKey();

