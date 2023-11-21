package animals;

public class Cat extends Animal {
    public static int count = 0;
    public Cat(int maxRun, int maxSwimM, String name, String nickName) {
        super(maxRun, maxSwimM, name, nickName);
        count++;
    }

    @Override
    public int getCount() {
        return count;
    }
}
