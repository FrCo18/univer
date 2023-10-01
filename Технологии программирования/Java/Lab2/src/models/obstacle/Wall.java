package models.obstacle;

public class Wall {
    private double heightM;

    public Wall(double heightM) {
        setHeightM(heightM);
    }

    public double getHeightM() {
        return heightM;
    }

    public void setHeightM(double heightM) {
        this.heightM = heightM;
    }
}
