package models.partipants;

import interfaces.DoInterface;

public class Human implements DoInterface {
    private double maxRunM;
    private double maxJumpM;

    public Human(double maxRunM, double maxJumpM) {
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
        return ParticipantType.HUMAN;
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
