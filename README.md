# PRÁCTICA 2. FÍSICAS

Para esta práctica se nos ha propuesto realizar una serie de ejercicios para familiarizarnos con las físicas, los eventos y los scripts.

### Ejercicio 1
Si ninguno de los objetos es físico lo que ocurre es que ambos son chocados y no se produce ningún desplazamiento, sino que se mantienen estáticos.

![ej1](https://user-images.githubusercontent.com/72921642/138611847-254c5044-858a-4649-a884-ef64e49b43cc.gif)

### Ejericio 2
Le añadí la física Rigidbody a la esfera y mantuve al cubo sin físicas. El resultado fue el esperado, el cubo no se movía al ser chocado, mientras que la esfera si se desplazaba, incluso caía al vacío si llegaba al límite del terreno.

![2](https://user-images.githubusercontent.com/72921642/138611899-3d0ae5b4-197e-4a5e-816d-cfdac53bb8b0.gif)

### Ejercicio 3
Ahora ambos objetos son Rigidbody, por lo tanto ambos deberían de moverse. Lo cierto es que ambos lo hacen, pero el cubo es mucho más difícil de mover que la esfera.

![3](https://user-images.githubusercontent.com/72921642/138611928-9ffc3e22-7d09-4e9b-9f12-5175ea736a49.gif)

### Ejercicio 4
La esfera tiene ahora 10 veces más masa que el cubo. Ahora la esfera es mucho más difícil de mover, algo esperado teniendo en cuenta el aumento de masa.

![4](https://user-images.githubusercontent.com/72921642/138611976-10d66dab-58f7-4d7f-940b-06a38cc4db6d.gif)

### Ejercicio 5
Activamos la propiedad IsTrigger del BoxCollider del cubo y mantenemos las mismas físicas en la esfera. Lo que ocurre ahora es que el cubo es atravesado.

![5](https://user-images.githubusercontent.com/72921642/138612024-b1a29055-3805-4477-9537-28018018db43.gif)

### Ejercicio 6
Además de activar el IsTrigger del cubo le añadimos físicas. Al ejecutar el juego el cubo atraviesa el terreno.

![6](https://user-images.githubusercontent.com/72921642/138612082-ff29f91d-0c43-4671-a1b3-2fcddaf33808.gif)

### Ejercicio 7
La esfera tiene 10 veces la masa del cubo y el cubo no puede rotar sobre el plano XZ. Para esto último desarrollé un nuevo script que asigné al cubo donde obtuve el componenete Rigidbody del cubo y establecí que este no puediera rotar mediante la sentencia 'rigidbody.freezeRotation = true'. Esto lo que hace es eliminar la rotación del objeto. Por tanto, en la ejecución la esfera será muy dificil de mover puesto que tiene una masa muy grande y el cubo al ser chocado no rotará sino que solo se moverá hacia la dirección en la que fue empujado.

![7](https://user-images.githubusercontent.com/72921642/138612118-004e37aa-5bd6-4f35-9881-2a9de83ee3e9.gif)

### Funcionamiento global de la práctica
He añadido todas las especificaciones que se pedían para esta práctica; los 3 tipos de cilindros, los cubos que aumentan y disminuyen su tamaño y una esfera que se mueve con las teclas I L J M. El funcionamiento es el siguiente:

- **Cilindros que aumentan su tamaño al chocar y aumentan la puntuacion del jugador**

![cilindro1](https://user-images.githubusercontent.com/72921642/138612192-61469e2d-fcfc-46dc-8432-13fb946ea216.gif)

- **Cilindros que se alejan cuando se acerca el jugador**

![cilindro2](https://user-images.githubusercontent.com/72921642/138612277-e5852aae-a5bf-45f1-b23d-d14aa9470471.gif)

- **Cilindros que se alejan al pulsar el espacio**

![cilindrosA]()

- **Cubos que aumentan y disminuyen de tamaño:** En este caso pasó algo bastante curioso, al acercarme con el jugador, el cubo disminuía de tamaño, pero cuando llegaba a tamaño 0 empezaba a crecer porque no se permiten tamaños de objetos negativos y se calculan en valor absoluto.

![cubos](https://user-images.githubusercontent.com/72921642/138612454-803a5604-5249-4584-82d5-dab37512ec6b.gif)

- **Esfera que se mueve con I L J M**

![player2](https://user-images.githubusercontent.com/72921642/138612515-3b038a8d-134e-4c85-832c-dd786b16986f.gif)