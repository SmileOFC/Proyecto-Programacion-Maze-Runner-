
# ![Mario's Maze](https://eltallerdehector.com/2022/07/26/mario-bros-png-logo/)

# Descripción del Proyecto

Mario’s Maze es un emocionante juego de laberintos 1vs1 inspirado en el universo de Super Mario. Cada jugador selecciona uno de los dos equipos disponibles y compite para ser el primero en llegar al centro. El juego combina estrategia y habilidad, ofreciendo una experiencia única y divertida para los fans de Mario y los juegos de laberintos.

En Mario's Maze, te embarcarás en una carrera trepidante a través de un laberinto lleno de trampas, buffs, cofres y desafíos únicos. El objetivo es ser el primer jugador en alcanzar la meta en el centro del tablero con todas tus fichas, utilizando tus habilidades especiales y estrategias para superar obstáculos y enemigos. Al inicio de la partida, cada ficha solo podrá ver un cuadrado del laberinto del tamaño `n x n`, donde `n` es igual a la visión de la ficha. Todo lo demás estará cubierto por una niebla que se despeja a medida que las fichas avanzan y exploran el tablero.

## Menú de Navegación

- [MECÁNICAS](#información-del-juego)
- [LEYENDA](#leyenda-controles)
- [CONTÁCTAME](#contribución)

### Información del Juego
El juego se desarrolla en tres escenas:

1. **Lobby**:

2. **Picks**:
    - Selección de equipos:
        - **Reino Champiñón**
        - **Reino Koopa**
    - Selección de fichas (3 de 5 disponibles para cada equipo)
    
3. **Juego**:
    - Información de la ficha en juego
    - Información de interacciones con el tablero
    - Visualización del tablero con el laberinto

## Leyenda Controles

| **Acción**             | **Tecla** |
|------------------------|-----------|
| Arriba                 |     W     |
| Abajo                  |     S     |
| Izquierda              |     A     |
| Derecha                |     D     |
| Menú                   |     Q     |
| Saltar Turno           |     R     |
| Abrir Tienda           |     T     |
| Usar Habilidad         |     F     |
| Seleccionar/Interactuar|     E     |

## Equipos y Fichas

### Reino Champiñón

| Ficha       | Pasos | Visión |
|-------------|-------|--------|
| Mario       | 12    | 1      |
| Luigi       | 10    | 1      |
| Hongo       | 5     | 2      |
| Yoshi       | 6     | 1      |
| Peach       | 7     | 2      |

### Reino Koopa

| Ficha       | Pasos | Visión |
|-------------|-------|--------|
| Bowser      | 8     | 1      |
| Donkey Kong | 4     | 2      |
| Koopa       | 3     | 3      |
| Waluigi     | 9     | 1      |
| Wario       | 11    | 1      |

## Habilidades Especiales

### Reino Champiñón
- **Mario**: Salta un muro que tenga en frente, con la agilidad que lo caracteriza en sus aventuras clásicas.
- **Luigi**: Revela trampas en su campo de visión, utilizando su valentía espectral para detectar peligros ocultos.
- **Hongo**: Buffea +1 la visión de todas las fichas aliadas, esparciendo su sabiduría micótica a sus compañeros.
- **Yoshi**: Genera un cuadrado 2x2 de visión en el tablero, gracias a su olfato y agilidad inigualables.
- **Peach**: Inmoviliza todas las fichas enemigas, permitiéndote repetir la ronda con la gracia real que la caracteriza.

### Reino Koopa
- **Bowser**: Se vuelve inmune por ese turno, desatando su furia imparable para protegerse de cualquier ataque.
- **Donkey Kong**: Rompe una muralla en la dirección seleccionada, demostrando su fuerza bruta.
- **Koopa**: Resta 1 visión y suma +5 pasos, sacrificando su vista para ganar velocidad en el tablero.
- **Waluigi**: Genera una trampa "Hueco" en una casilla del tablero, siempre travieso y astuto en sus movimientos.
- **Wario**: Resta 3 pasos y suma 1 visión, ajustando su torpe equilibrio para ver más claramente y planificar sus movimientos.

## Elementos del Tablero

El tablero de juego está lleno de diversos elementos que afectarán tu progreso o te ayudaran a llegar mas rapido a la meta:

### Trampas
- **Hueco**: Al pisarlo, la ficha regresa al inicio del juego, como si cayera en un agujero sin fondo.
- **Bomba**: Al activarla, la ficha retrocede dos casillas, como si hubiera sido empujada por una explosión.
- **Reja**: Al activarla, encierra a la ficha volviéndola inmóvil, atrapándola como en una trampa de metal.

### Buffs
- **Estrella**: Vuelve inmune a la ficha, otorgándole el poder estelar de Mario.
- **Hongo**: Buffea +10 pasos a la ficha, dándole un impulso de energía.
- **Flor**: Buffea +2 visión a la ficha, iluminando su camino con el poder de la flor de fuego.

### Cofres
- **Común**: Precio 1 coin, suma 1 visión y 3 pasos.
- **Épico**: Precio 3 coins, suma 2 visión y 4 pasos.
- **Legendario**: Precio 5 coins, suma 3 visión y 5 pasos.

### Llaves y Puertas
- **Llaves**: Necesarias para abrir las puertas y acceder a la meta. Ubicadas aleatoriamente en el tablero a la izquierda o a la derecha.
- **Puertas**: Cada equipo tiene una puerta que solo puede ser abierta por la llave correspondiente.

## Tienda

La tienda dispone de ítems (Apoyo) y poderes (Ofensivos). Su uso está limitado a una vez por ronda, pero la cantidad de compras es ilimitada. Si un jugador usa la tienda, no podrá volver a usarla en esa ronda ni hasta que el otro jugador la use también.

### Ítems (Apoyo) - Precio: 2 coins
- **Escudo**: Vuelve inmune a la ficha seleccionada, protegiéndola de cualquier trampa o peligro.
- **Escalera**: Genera una escalera en la dirección seleccionada, considerada un pasillo libre para el próximo turno, permitiendo a la ficha saltar obstáculos.

### Poderes (Ofensivos) - Precio: 3 coins
- **Bala**: Empuja a la ficha enemiga seleccionada hasta 5 pasos en dirección contraria, como si fuera golpeada por una bala.
- **Máscara**: Vuelve 0 la visión del jugador enemigo seleccionado en su próximo turno, cegándolo temporalmente.

## Contribución

Las contribuciones son bienvenidas. Por favor, abre un issue o envía un pull request para discutir cualquier cambio que desees realizar.

---

¡Gracias por jugar Mario's Maze!
