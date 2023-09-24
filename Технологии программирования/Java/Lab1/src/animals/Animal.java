package animals;

public class Animal {
    double maxRunM;
    double maxSwimM;

    //Название животного
    String name;

    // Имя животного
    String nickName;

    public Animal(int maxRun, int maxSwimM, String name, String nickName) {
        setMaxRunM(maxRun);
        setMaxSwimM(maxSwimM);
        setName(name);
        setNickName(nickName);
    }

    public void setNickName(String nickName) {
        this.nickName = nickName;
    }

    public String getNickName() {
        return nickName;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setMaxRunM(double maxRunM) {
        this.maxRunM = maxRunM;
    }

    public double getMaxRunM() {
        return maxRunM;
    }

    public void setMaxSwimM(double maxSwimM) {
        this.maxSwimM = maxSwimM;
    }

    public double getMaxSwimM() {
        return maxSwimM;
    }

    public String run(double runM) throws Exception {
        if (runM > getMaxRunM()) {
            throw new Exception(String.format("Max run for %s %s is: %f", getName(), getNickName(), getMaxRunM()));
        }

        return String.format("Животное %s, по имени %s, пробежало %f метров.", getName(), getNickName(), runM);
    }

    public String swim(double swimM) throws Exception {
        if (swimM > getMaxSwimM()) {
            throw new Exception(String.format("Max run for %s %s is: %f", getName(), getNickName(), getMaxSwimM()));
        }

        return String.format("Животное %s, по имени %s, проплыло %f метров.", getName(), getNickName(), swimM);
    }
}
