package models.obstacle;

public class Wall implements Obstacle {
    private double heightM;

    public Wall(double heightM) {
        setHeightM(heightM);
    }

    private double getHeightM() {
        return heightM;
    }

    @Override
    public double getDistance() {
        return getHeightM();
    }

    @Override
    public String getName() {
        return "Стена";
    }

    public void setHeightM(double heightM) {
        this.heightM = heightM;
    }

    @Override
    public ObstacleType getType() {
        return ObstacleType.WALL;
    }
}
