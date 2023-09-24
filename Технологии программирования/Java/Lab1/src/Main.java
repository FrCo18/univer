import animals.Animal;

import java.util.Random;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {
        Animal[] animals = new Animal[]{
                (new Animal(200, 0, "Домашний Кот", "Мурзик")),
                (new Animal(500, 10, "Собака", "Бобик")),
                (new Animal(1000, 10, "Тигр", "Мурзик"))
        };

        Random rnd = new Random();
        for (Animal animal : animals) {
            try {
                System.out.printf(animal.run(rnd.nextDouble(0, animal.getMaxRunM())));

                if (animal.getMaxSwimM() == 0) {
                    System.out.printf(animal.swim(0) + "\n");
                } else {
                    System.out.printf(animal.swim(rnd.nextDouble(0, animal.getMaxSwimM())) + "\n");
                }
            } catch (Exception e) {
                throw new RuntimeException(e);
            }
        }

        System.out.printf("Count animals: %d", animals.length);
    }
}