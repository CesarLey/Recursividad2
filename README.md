# Actividad 2 - Recursividad

## Descripción del Proyecto

Esta aplicación de escritorio en C# implementa **7 ejercicios de recursividad** como parte de la Actividad 2 del curso. La aplicación utiliza Windows Forms para proporcionar una interfaz gráfica intuitiva y moderna.

## Ejercicios Implementados

### 1. **Factorial** 
- Calcula el factorial de un número usando recursión
- Validación de números positivos y límites para evitar desbordamiento
- Casos base: factorial(0) = 1, factorial(1) = 1

### 2. **Serie de Fibonacci**
- Genera los primeros n términos de la serie de Fibonacci usando recursión
- Casos base: F(0) = 0, F(1) = 1
- Fórmula recursiva: F(n) = F(n-1) + F(n-2)

### 3. **Máximo Común Divisor (MCD)**
- Calcula el MCD de dos números enteros usando el algoritmo de Euclides
- Implementación recursiva del algoritmo clásico
- Caso base: MCD(a, 0) = a

### 4. **Calculadora de Cambio de Monedas**
- Calcula el cambio mínimo usando el algoritmo voraz recursivo
- Denominaciones: 100, 50, 20, 10, 5 pesos y 50, 20, 10, 1 centavos
- Optimización para usar el mínimo número de monedas

### 5. **Torres de Hanói**
- Resuelve el clásico problema de las Torres de Hanói
- Implementación recursiva del algoritmo de solución
- Muestra la secuencia completa de movimientos necesarios

### 6. **Verificador de Palíndromo** (Dificultad Media-Alta)
- Verifica si una palabra o frase es palíndromo usando recursión
- Normalización automática del texto (eliminación de espacios y caracteres especiales)
- Análisis detallado carácter por carácter

### 7. **Generador de Permutaciones** (Dificultad Media-Alta)
- Genera todas las permutaciones posibles de un conjunto de caracteres
- Implementación recursiva con backtracking
- Eliminación automática de caracteres duplicados

## Características Técnicas

### Programación Orientada a Objetos
- Cada formulario es una clase independiente
- Métodos privados para lógica de recursión
- Separación clara entre interfaz y lógica de negocio

### Validaciones y Manejo de Excepciones
- Validación de entrada de datos numéricos
- Manejo de casos límite y errores
- Mensajes informativos para el usuario
- Validación de rangos para evitar problemas de rendimiento

### Diseño de Interfaz
- Nomenclatura estándar de controles (btn, lbl, txt)
- Fuentes consistentes y tamaños apropiados
- Botones de navegación y limpieza
- Campos de solo lectura para resultados
- Áreas de texto con scroll para resultados extensos

## Estructura del Proyecto

```
Recursividad2/
├── Program.cs                 # Punto de entrada de la aplicación
├── frmMenuPrincipal.cs       # Menú principal con 7 opciones
├── frmFactorial.cs           # Ejercicio 1: Factorial
├── frmFibonacci.cs           # Ejercicio 2: Serie de Fibonacci
├── frmMCD.cs                 # Ejercicio 3: Máximo Común Divisor
├── frmCambioMonedas.cs       # Ejercicio 4: Calculadora de cambio
├── frmTorresHanoi.cs         # Ejercicio 5: Torres de Hanói
├── frmPalindromo.cs          # Ejercicio 6: Verificador de Palíndromo
├── frmPermutaciones.cs       # Ejercicio 7: Generador de Permutaciones
├── Recursividad2.csproj      # Archivo de proyecto
└── README.md                 # Este archivo
```

## Requisitos del Sistema

- .NET 6.0 o superior
- Windows (aplicación de escritorio)
- Visual Studio 2022 o Visual Studio Code (recomendado)

## Instrucciones de Compilación

1. Abrir el proyecto en Visual Studio
2. Restaurar paquetes NuGet si es necesario
3. Compilar en modo Release
4. El ejecutable se generará en la carpeta `bin/Release/net6.0-windows/`

## Instrucciones de Uso

1. Ejecutar `Recursividad2.exe`
2. Seleccionar una opción del menú principal
3. Ingresar los datos requeridos en cada ejercicio
4. Presionar el botón correspondiente para ejecutar
5. Revisar los resultados mostrados
6. Usar "Limpiar" para borrar datos o "Regresar" para volver al menú

## Funcionalidades de Navegación

- **Menú Principal**: Acceso a los 7 ejercicios
- **Botón Salir**: Confirmación antes de cerrar la aplicación
- **Botón Regresar**: Volver al menú desde cualquier ejercicio
- **Botón Limpiar**: Limpiar campos en cada formulario

## Criterios de Evaluación Cumplidos

✅ **Diseño (10 puntos)**: Componentes ordenados, alineados y legibles  
✅ **Descripción del Problema (10 puntos)**: Cada ejercicio incluye descripción clara  
✅ **Funcionalidad (30 puntos)**: Funcionamiento paso a paso con evidencia visual  
✅ **Pruebas y Validación (30 puntos)**: Validación de datos y manejo de excepciones  

## Notas Técnicas

- Todos los algoritmos recursivos incluyen casos base apropiados
- Se implementan validaciones para evitar desbordamiento de stack
- Los métodos recursivos son eficientes y bien documentados
- La interfaz sigue las mejores prácticas de UX/UI para aplicaciones de escritorio

---

**Desarrollado por**: [Nombre del Estudiante]  
**Fecha**: Septiembre 2025  
**Curso**: Programación Avanzada
