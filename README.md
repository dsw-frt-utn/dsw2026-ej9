# Ejercicio N° 9
## Desarrollo de Software
### Herencia y propiedades

1. Crear una rama de larga duración **development**, localmente, y trabajar sobre ésta.
2. Refactorizar el código aplicando herencia según el caso.
3. Reemplazar los métodos getters y setters, y campos por propiedades, tener en cuenta la accesibilidad en cada caso.
4. Respetar que al crear una cuenta bancaria se reciba el número y el saldo en el constructor.
5. La tasa de interés se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor.
6. El límite de descubierto se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor.
7. Agregar las siguientes reglas:
    * El monto recibido por cualquier operación no puede ser menor o igual a 0, de lo contrario generar una excepción del tipo `InvalidAmount`.
    * Cualquier operación se debe realizar si la cuenta está activa, en cualquier otro caso generar una excepción del tipo `AccountNotActive`.
    * Se debe contar con saldo para realizar un retiro, caso contrario debe generar una excepción `InsufficientBalance` y la cuenta debe quedar suspendida. Tener en cuenta el límite de descubierto si corresponde
8. Instanciar 4 cuentas (dos de cada tipo) y realizar diferentes operaciones que permitan comprobar todas las funciones posibles.
9. Recorrer las 4 cuentas creadas, crear un `record` que contenga el número, tipo y saldo. Mostrar por consola el contenido del `record`.

**Consideraciones**:
- Las excepciones deben incluir los siguiente mensajes:
- `InvalidAmount` -> El monto ingresado no es válido para la operación solicitada
- `AccountNotActive` -> No se puede operar con la cuenta {estado} (reemplazar por el estado en el que se encuentra)
- `InsufficientBalance` -> La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.
- La aplicación no debe interrumpir su funcionamiento si se produce una excepción.
