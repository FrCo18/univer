package interfaces;

import models.obstacle.Obstacle;
import models.partipants.ParticipantType;

public interface DoInterface {
    boolean run(double runM);
    boolean jump(double jumpM);
    ParticipantType getType();
    boolean contest(Obstacle obstacle);
}
