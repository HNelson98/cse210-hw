public abstract class Shape {
    string _color;
    int _width;
    int _height;

    public Shape(string color) {
        _color = color;
    }
    public Shape(string color, int sides) {
        _color = color;
        _height = sides;
        _width = sides;
    }
    public Shape(string color, int width, int height) {
        _color = color;
        _width = width;
        _height = height;
    }
    public string GetColor() {
        return _color;
    }

    public void SetColor(string color) {
        _color = color;
    }

    public abstract double GetArea();

}