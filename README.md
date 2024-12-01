# Calculadora Básica con Windows Forms

## Descripción

Este proyecto consiste en desarrollar una calculadora básica en C# utilizando Windows Forms. La calculadora debe realizar operaciones matemáticas básicas como suma, resta, multiplicación y división. Además, debe gestionar un historial de las operaciones realizadas, permitir limpiar la entrada con un botón "Clear" y redimensionar los elementos de la interfaz cuando el formulario cambie de tamaño.

## Requisitos Funcionales

### 1. Interfaz Gráfica
- **TextBox**: Para mostrar los números ingresados y el resultado de las operaciones.
- **Botones Numéricos**: Botones del 0 al 9.
- **Botones de Operaciones Básicas**: Suma (+), resta (-), multiplicación (*), y división (/).
- **Botón Clear**: Borra el contenido del TextBox.
- **Botón Igual (=)**: Muestra el resultado de la operación.
- **ListBox**: Registra el historial de operaciones en el lateral derecho, con el formato `operación = resultado`.
- **Botón +/-**: Cambia el signo del número actual.
- **Botón del Punto (.)**: Permite ingresar números decimales.

### 2. Operaciones Matemáticas
- La calculadora debe realizar operaciones básicas (suma, resta, multiplicación y división) de dos números.
- Las operaciones deben realizarse una a la vez (no es necesario encadenar operaciones, aunque si lo implementas, se considerará un extra).
- El botón de igual debe calcular y mostrar el resultado en el TextBox.
- El resultado de la operación debe guardarse en el ListBox del historial.

### 3. Historial de Operaciones
- Cada operación realizada debe ser registrada en el ListBox, con el formato `operación = resultado` (por ejemplo: 5 + 3 = 8).
- El historial debe mostrar las operaciones realizadas durante la sesión actual, incluso después de borrar la pantalla con el botón Clear.

### 4. Botón Clear
- El botón Clear debe borrar el contenido actual del TextBox sin borrar el historial de operaciones.

### 5. Redimensionamiento del Formulario
- Cuando el usuario redimensione la ventana del formulario, todos los elementos (botones, TextBox, ListBox) deben ajustarse proporcionalmente.
- El diseño debe seguir siendo limpio y funcional después de redimensionar la ventana.

## Instrucciones para el Desarrollo

### 1. Diseño de la Calculadora
- Ajusta las propiedades `Dock` y `Anchor` para que los controles se ajusten cuando el formulario se redimensione.

### 2. Implementación del Código
- El botón igual (=) debe calcular el resultado de la operación y mostrarlo en el TextBox.
- El botón +/- debe cambiar el signo del número actual en el TextBox.

### 3. Manejo del Historial
- Cada vez que se realice una operación y el usuario presione el botón igual, guarda la operación y el resultado en el ListBox del historial.

### 4. Redimensionamiento Dinámico
- Asegúrate de que todos los controles (botones, TextBox, y ListBox) se ajusten proporcionalmente cuando el usuario cambie el tamaño del formulario.

---
### Bibligografia 

https://es.stackoverflow.com/questions/605633/calculadora-c-windows-forms

https://es.sharpcoderblog.com/blog/creating-a-simple-calculator-in-csharp

https://bravedeveloper.com/2024/06/09/calculadora-simple-en-c/

