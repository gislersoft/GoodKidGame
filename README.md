# GoodKidGame
GoodKidGame es un prototipo de videojuego sobre un chico punketo que adora la música.

# Restricciones del Juego
- No puede haber violencia explicita el juego se va a distribuir para niños.
- Debe ser un platformer en 3D.
- Los items que el jugador toma son notas musicales que cada una tiene un valor, sonido y color diferente.
- El personaje principal debe ser el niño de gorra.
- No se pueden usar modelos que tengan derechos de autor, solo son validos elementos con licencia CONFIRMADA Creative Commons No attribution.

# Para Resolver conflictos

1. Hacer pull de la rama para verificar si hay conflictos ```git pull origin develop```
2. En caso de conflictos validar que archivos estas en conflicto, si los archivos son de texto entonces resolver el conflicto con un editor de texto. Si el conflicto es con un archivo binario entonces abortar el merge con: ```git merge --abort``` 
3. Si se aborto el merge por archivos binarios entonces sacar los archivos que deben quedar aparte (copiarlos a otra carpeta), reintentar el pull, git mostrara nuevamente el conflicto con los archivos binarios en este caso reemplazar los archivos con los que se copiaron. Verificar los cambios con ```git status``` si luego de analizar los cambios esta deacuerdo con ellos entonces agregar cada archivo con ```git add <archivo>``` finalmente cerramos el merge con ```git commit```

# Enviar Cambios

1. Haga un backup de sus cambios si aun no tiene dominio de git.
2. Valide sus cambios locales con ```git status```
3. Hacer pull de la rama para verificar si hay conflictos ```git pull origin develop``` para validar si tiene lo ultimo y si no hay conflictos
4. Si no hay conflictos encontes agregar cada archivo con ```git add <archivo>`` si quiere agregar todos los cambios al mismo tiempo y esta seguro de que no se va a llevar otros cambios no deseados utilice ```git add .``
5. Haga el commit de sus cambios con ```git commit -m "Este es mi conjunto de cambios"``
6. Mueva su tarea en el project kanban al estado "Testing" y avise a su manager que el cambio esta listo para pruebas

# Responsabilidades del Trabajo en Equipo

## Equipo de QA y Game Design

Este equipo descarga los ultimos cambios de la rama qa:

1. El QA clona el repositorio: ```git clone https://github.com/gislersoft/GoodKidGame.git```
2. El QA actualiza las ramas: ```git fetch```
3. El QA se cambia a la rama qa: ```git checkout qa```
4. El QA baja los ultimos cambios de la rama: ```git pull origin qa```

### Tareas del QA y Game Design

1. Reportar bugs o mejoras como un Issue dando la mejor descripción posible de cómo reproducir el problema, se apoya en imagenes.
2. Informar al equipo correspondiente el bug, hacer tracking de los issues y tagear a los responsables de solucionar el problema.
3. Crear el manual del Juego en formato PDF, este manual se distribuirá con el Juego.
4. El manager QA debe verificar que todos los miembros del equipo tengan tareas asignadas en caso de no tener funcionalidades para probar debe tomar el tiempo que un QA se queda sin trabajo.
5. Diseñar el Juego pasarle al equipo de Modelado los diseños preliminares del juego.
6. Dirigir el diseño del juego y verificar que las restricicones se cumplan.

## Equipo de Scripting 

Este equipo se encarga de crear y programar las mecánicas del juego:

1. El desarrollador clona el repositorio: ```git clone https://github.com/gislersoft/GoodKidGame.git```
2. El desarrollador actualiza las ramas: ```git fetch```
3. El desarrollador se cambia a la rama develop: ```git checkout develop```
4. El desarrollador baja los ultimos cambios de la rama develop: ```git pull origin develop```

### Tareas del Scripting Developer

1. Crear mecanicas basicas del juego.
2. Integrarse con el equipo de UI para reflejar los estados en el HUD del juego (vidas, score, etc).
3. Integrarse con el equipo de Modelado para programar mecanicas u otros aspectos del juego.
4. Subir los cambios a la rama develop.

## Equipo de Audio

Los ingenieros del equipo de audio no solo buscan los audio o los crean también son los encargados de programar el audio.

1. Proveer de audio y música al juego (solo pueden usar creative commons no attribution license)
2. Deben agregar el audio a las escenas y a los scripts (para esto deben ponerse con el equipo de scripting)

## Equipo de Modelado y Level Design

Son los encargado y los unicos que pueden tocar la escena Level1.scene

1. Crear los modelos 3D del juego y enviarselos a los de Texturizado
2. Hacer el Level design
3. Animar los modelos 3D que ya esten texturizados.


## Equipo de UI

1. Crear el menu principal y el HUD del juego
2. Crean las imagenes de UI
3. Estan en capacidad de programar e integrarse con Scripting para los estados del juego (Vidas, Score, etc)

## Equipo de Texturizado

1. Se encargan de hacer el UV
2. Se encargan de texturizar los modelos y enviar los modelos texturizados para que el equipo de modelado inicie la animacion si se requiere
3. Este equipo esta en constante comunicacion con el de Modelado y UI estos dos managers deben hablarse bastante.

# Equipo de Soporte

Soluciona los problemas tecnicos.







