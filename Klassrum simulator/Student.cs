namespace Föreläsning1;

public class Student
{
    public string Name;
    public int ProgrammingLevel;
    public bool IsPresent;
    public List<Tool> Tools;
    public void LearnTool(Tool tool)
    {
        bool alreadyKnown = false;

        foreach (Tool t in Tools)
        {
            if (t.Name == tool.Name)
            {
                alreadyKnown = true;
                break;
            }

            if (!alreadyKnown)
            {
                Tools.Add(tool);
            }
        }
    }
}
