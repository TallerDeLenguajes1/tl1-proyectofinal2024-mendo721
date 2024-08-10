# Bastardos sin Gloria
***Este juego está basado en la icónica película "Bastardos Sin Gloria" de Quentin Tarantino. En esta aventura te veras inmerso en la escena final de la película, donde los Bastardos se infiltran en un cine en el corazón de París, con la misión de acabar con los altos mandos del Tercer Reich. Asume el papel de un Bastardo, y atraviesa peligros desafíos mientras te adentras en el cine para cumplir con la misión más importante de la resistencia. ¿Tienes lo necesario para cambiar el curso de la historia?***
---
## Menu
- 1. **Jugar** : Vas a empeza una nueva partida con 10 personajes que se generaran aleatoriamente.
- 2. **Cargar Partida** : Vas a continuar alguna partida que no se pudo terminar, ya que cada nueva partida se va guardando automaticamente.
- 3. **Historial de ganadores** : Aqui podemos ver todos los jugadores capaces de superar la mision.
- 4. **Salir**
---
## Desarrollo de la partida
- 1. **Presentacion** : Empezamos el juego con una breve presentacion.
- 2. **Descripcion de la mision** : Cuando elegimos la opcion ***Jugar*** nos muetra una descripcion de la mision.
- 3. **Seleccion de personajes** : Tanto cuando empezamos una nueva partida como cuando cargamos nos da la oportunidad de elegir entre una lista ya predefinida de personajes con caracteristicas diferentes.
- 4. **Condiciones del clima** : Con el uso de una API determinamos el clima actual de Paris Francia, lugar donde se lleva a cabo la mision. Dependiendo de las condiciones del clima nuestro personaje puede sufrir una merma en sus caracteristicas.
- 5. **Generacion de enemigos** : Estos tienen nombres, tipos y apodos predefinidos. Sin embargo sus caracteristicas se cargan de manera aleatoria.
- 6. **Menu de combate** : A la hora del combate este se dara por turnos, el usuario tendra la posibilidad decidir que accion tomara su personaje en su turno. 
- 7. **Acciones de combate**: 
***Atacar*** : El personaje ataca al enemigo y se aplica una funcion para calcular el daño al enemigo.
***Defenderse*** : El personaje utiliza su turno solo para defenderse. A la hora de que el enemigo ataque se agregara una variable de defensa para recibir menos daño.
***Rendirse*** : Con esta opcion nos damos por vencidos. Sin embargo despues de recibir un mensaje de nuestro teniente decepcionado, la partida se guada donde nos rendimos dandonos la posibilidad de elegir otro personaje e intentar ganar donde nos quedamos.
- 8. **Mejoras de Estadisticas** : A medida que vamos derrotando a nuetros enemigos luego de cualquier combate el juego nos dara la posibilidad de sumar un punto de mejora a la caracteristica que queramos.
- 9. **Guardado de los ganadores** : Cuando por fin nuestro personaje logra vencer a los altos mandos nuestro nombre se guarda automaticamente un listado de ganadores.
---
## API
La Api usada es OpenWeatherMap extraida del siguiente link:
https://openweathermap.org/api.
La api fue utilizada para obtener el clima de la region donde se desarrolla el juego.
Dependiendo de la temperatura esta le afectara a las caracteristicas de nuestro personaje.
**Respaldo**: En caso de no tener conexion a internet el juego extrae los climas ya cargados de partidas anteriores que se guardaron en un archivo Json.