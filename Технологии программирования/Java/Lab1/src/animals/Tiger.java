package animals;

public class Tiger extends Animal {
    public static int count = 0;
    public Tiger(int maxRun, int maxSwimM, String name, String nickName) {
        super(maxRun, maxSwimM, name, nickName);
        count++;
    }

    @Override
    public int getCount() {
        return count;
    }
}
