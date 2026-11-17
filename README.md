# CombustiPlus — Estación Bávaro

Tarea práctica de la Unidad 2 · **ISW-123 Programación Media** · Universidad Central del Este (UCE)

**Estudiante:** Frankeny Antonio Castillo Paniagua · **Matrícula:** 2025-0794

Programa en **Windows Forms (C#, .NET 10)** que registra cada despacho de gasolina, calcula el precio y muestra el total del día.

## Reglas

| Combustible | Precio por galón |
|---|---|
| Premium | RD$ 290.00 |
| Regular | RD$ 272.00 |
| Gasoil  | RD$ 225.00 |

1. La placa debe tener 7 caracteres (ej. `A123456`).
2. Los galones deben ser más de 0.
3. 20 galones o más tienen 2 % de descuento.
4. Con tarjeta se cobra 3 % más; en efectivo no cambia.
5. Primero se aplica el descuento y después el recargo de la tarjeta.

## Dónde está cada requisito

| Requisito | Dónde |
|---|---|
| R1 · La ventana | `Form1.Designer.cs` (controles) y constructor de `Form1.cs` (llena los ComboBox) |
| R2 · La clase Despacho | `Despacho.cs` (propiedades y `ToString()`) |
| R3 · Validar los datos | `Form1.DatosValidos()` con `if` y `MessageBox` |
| R4 · Calcular el precio | `Form1.PrecioPorGalon()` (expresión `switch`) y `Form1.CalcularTotal()` |
| R5 · Guardar y resumir | `List<Despacho> despachos`, `btnDespachar_Click` y `MostrarResumen()` con `foreach` |
| R6 · Galones por combustible | `btnPorCombustible_Click` con `Dictionary<string, decimal>` |

## Pruebas

| # | Datos | Resultado |
|---|---|---|
| P1 | A123456 · Regular · 10 gal · Efectivo → Despachar | RD$ 2,720.00 |
| P2 | G456789 · Premium · 22 gal · Tarjeta → Despachar | RD$ 6,439.97 |
| P3 | L778899 · Gasoil · 30 gal · Efectivo → Despachar | RD$ 6,615.00 |
| Resumen | Después de P1, P2 y P3 | 3 despachos · Vendido RD$ 15,774.97 · Galones 62.0 · Mayor: #03 |
| P4 | Placa AB12 → Cotizar | Mensaje: la placa debe tener 7 caracteres |
| P5 | Galones 0 → Cotizar | Mensaje: los galones deben ser más de 0 |
| P6 | Galones por combustible | Regular 10.0 · Premium 22.0 · Gasoil 30.0 |

## Cómo ejecutarlo

Abrir `CombustiPlus.slnx` en Visual Studio (con .NET 10) y pulsar **F5**.
