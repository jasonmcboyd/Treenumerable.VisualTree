$wpfProjectFile = "..\Source\Treenumerable.VisualTree.Silverlight\Treenumerable.VisualTree.Silverlight.csproj"
$silverlightProjectFile = "..\Source\Treenumerable.VisualTree.Wpf\Treenumerable.VisualTree.Wpf.csproj"

nuget pack $wpfProjectFile -Prop Configuration=Release -Build
nuget pack $silverlightProjectFile -Prop Configuration=Release -Build