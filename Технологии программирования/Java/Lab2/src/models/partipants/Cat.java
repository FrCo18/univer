package models.partipants;

import interfaces.DoInterface;
import models.obstacle.Obstacle;
import models.obstacle.ObstacleType;

public class Cat extends Participant {
    private double maxRunM;
    private double maxJumpM;

    public Cat(double maxRunM, double maxJumpM) {
        setMaxJumpM(maxJumpM);
        setMaxRunM(maxRunM);
    }

    @Override
    public boolean run(double runM) {
        return runM <= getMaxRunM();
    }

    @Override
    public boolean jump(double jumpM) {
        return jumpM <= getMaxJumpM();
    }

    @Override
    public ParticipantType getType() {
        return ParticipantType.CAT;
    }

    public double getMaxRunM() {
        return maxRunM;
    }

    public void setMaxRunM(double maxRunM) {
        this.maxRunM = maxRunM;
    }

    public double getMaxJumpM() {
        return maxJumpM;
    }

    public void setMaxJumpM(double maxJumpM) {
        this.maxJumpM = maxJumpM;
    }
}
