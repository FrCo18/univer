package animals;

public class Dog extends Animal {
    public static int count = 0;
    public Dog(int maxRun, int maxSwimM, String name, String nickName) {
        super(maxRun, maxSwimM, name, nickName);
        count++;
    }

    @Override
    public int getCount() {
        return count;
    }
}
