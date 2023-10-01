package models.obstacle;

public class TreadMill {
    private double lengthM;

    public TreadMill(double lengthM) {
        setLengthM(lengthM);
    }

    public double getLengthM() {
        return lengthM;
    }

    public void setLengthM(double lengthM) {
        this.lengthM = lengthM;
    }
}
