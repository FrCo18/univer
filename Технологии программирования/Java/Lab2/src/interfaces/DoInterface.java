package interfaces;

import models.partipants.ParticipantType;

public interface DoInterface {
    public boolean run(double runM);
    public boolean jump(double jumpM);
    public ParticipantType getType();
}
