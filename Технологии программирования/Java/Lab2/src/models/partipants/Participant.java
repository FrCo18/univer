package models.partipants;

import interfaces.DoInterface;
import models.obstacle.Obstacle;
import models.obstacle.ObstacleType;

public abstract class Participant implements DoInterface {
    public boolean contest(Obstacle obstacle) {
        if (obstacle.getType() == ObstacleType.TREADMILL) {
            return this.run(obstacle.getDistance());
        }

        return this.jump(obstacle.getDistance());
    }
}
