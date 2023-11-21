package models.obstacle;

public class TreadMill implements Obstacle {
    private double lengthM;

    public TreadMill(double lengthM) {
        setLengthM(lengthM);
    }

    private double getLengthM() {
        return lengthM;
    }

    public void setLengthM(double lengthM) {
        this.lengthM = lengthM;
    }

    @Override
    public ObstacleType getType() {
        return ObstacleType.TREADMILL;
    }

    @Override
    public double getDistance() {
        return getLengthM();
    }

    @Override
    public String getName() {
        return "Беговая дорожка";
    }
}
