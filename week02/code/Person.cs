public class Person {
    public readonly string Name;
    public int Turns { get; set; }

    internal Person(string name, int turns) {
        Name = name;
        if (turns >= 1) {
            Turns = turns;
        }
        else {
            Turns = -1;
        }
    }

    public override string ToString() {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}