using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace Exmaple2._0;

public class EmbeddedViewLocator
    : IDataTemplate
{
    public static Control BuildView(object? data)
    {
        if (data is not null)
        {
            var name = data.GetType().AssemblyQualifiedName!.Replace("ViewModel", "View");
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }
        else
        {
            return new TextBlock { Text = "Data object is null" };
        }
    }

    public Control Build(object? data)
    {
        return BuildView(data);
    }

    public bool Match(object? data)
    {
        return data is not null;
    }
}
