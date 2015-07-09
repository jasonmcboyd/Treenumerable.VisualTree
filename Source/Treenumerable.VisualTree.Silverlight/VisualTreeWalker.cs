using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Treenumerable.VisualTree
{
    public class VisualTreeWalker : ITreeWalker<DependencyObject>
    {
        public IEnumerable<DependencyObject> GetChildren(DependencyObject node)
        {
            int count = VisualTreeHelper.GetChildrenCount(node);
            for (int i = 0; i < count; i++ )
            {
                yield return VisualTreeHelper.GetChild(node, i);
            }
        }

        public bool TryGetParent(DependencyObject node, out DependencyObject parent)
        {
            parent = VisualTreeHelper.GetParent(node);
            return parent != null;
        }
    }
}
