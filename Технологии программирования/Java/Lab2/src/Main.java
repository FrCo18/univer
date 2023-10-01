import interfaces.DoInterface;
import models.obstacle.TreadMill;
import models.obstacle.Wall;
import models.partipants.Cat;
import models.partipants.Human;
import models.partipants.Robot;

import java.util.ArrayList;
import java.util.List;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {
        DoInterface[] partipants = new DoInterface[]{
                (new Human(5000, 2)),
                (new Cat(7000, 3)),
                (new Robot(10000, 10))
        };

        List<Object> obstacles = new ArrayList<Object>();
        obstacles.add((new TreadMill(5000)));
        obstacles.add((new Wall(1)));
        obstacles.add((new TreadMill(6000)));
        obstacles.add((new Wall(2)));
        obstacles.add((new TreadMill(7000)));
        obstacles.add((new Wall(3)));
        obstacles.add((new TreadMill(8000)));
        obstacles.add((new Wall(4)));

        for (DoInterface participant : partipants) {
            for (var obstacle : obstacles) {
                if (obstacle instanceof Wall && !doJob((Wall) obstacle, participant)) {
                    break;
                }

                if (obstacle instanceof TreadMill && doJob((TreadMill) obstacle, participant)) {
                    break;
                }
            }
        }
    }

    private static boolean doJob(Wall obstacle, DoInterface participant) {
        double height = obstacle.getHeightM();
        if (participant.jump(height)) {
            System.out.printf("%s смог перепрыгнуть стену в %.2f метров\n", participant.getType(), height);
            return true;
        }

        System.out.printf("%s не смог перепрыгнуть стену в %.2f метров\n", participant.getType(), height);
        return false;
    }

    private static boolean doJob(TreadMill obstacle, DoInterface participant) {
        double length = obstacle.getLengthM();
        if (participant.run(length)) {
            System.out.printf("%s смог пробежать расстояние в %.2f метров\n", participant.getType(), length);
        }

        System.out.printf("%s не смог пробежать расстояние в %.2f метров\n", participant.getType(), length);
        return false;
    }
}