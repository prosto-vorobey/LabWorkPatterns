using System.Windows.Forms;
public interface IDisplayFactory
{
    ConsoleDisplay CreateConsoleDisplay();
    GraphicsDisplay CreateGraphicsDisplay(Panel panel);

}

public class SingleBorder : IDisplayFactory
{
    public ConsoleDisplay CreateConsoleDisplay()
    {
        return new ConsoleDisplay(new ConsolePrimitives());

    }
    public GraphicsDisplay CreateGraphicsDisplay(Panel panel)
    {
        return new GraphicsDisplay(panel,new GraphicsPrimitives());

    }

}

public class DoubleBorder : IDisplayFactory
{
    public ConsoleDisplay CreateConsoleDisplay()
    {
        return new ConsoleDisplay(new ConsoleDoubleLineDecorator(new ConsolePrimitives()));

    }
    public GraphicsDisplay CreateGraphicsDisplay(Panel panel)
    {
        return new GraphicsDisplay(panel, new GraphicsPrimitives());
        //return new GraphicsDisplay(panel, new GraphicsDoubleLineDecorator(new GraphicsPrimitives()));

    }

}
