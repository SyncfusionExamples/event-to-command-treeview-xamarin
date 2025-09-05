# event-to-command-treeview-xamarin
This repository demonstrates how to implement the Event-to-Command pattern with the Syncfusion Xamarin.Forms TreeView control. The provided samples show how to bind TreeView events—such as node selection or checking—to commands in your ViewModel, enabling a clean MVVM architecture and improved testability in your Xamarin.Forms applications.

## Sample

### XAML
```xaml
<ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView"
                             ItemHeight="40"
                             Indentation="40"
                             ExpanderWidth="40"
                             ChildPropertyName="States" 
                             SelectionBackgroundColor="Khaki"
                             ItemsSource="{Binding CountriesInfo}"
                             AutoExpandMode="RootNodesExpanded">
            <syncfusion:SfTreeView.Behaviors>
                <local:EventToCommandBehavior EventName="SelectionChanged" Command="{Binding SelectionChangedCommand}"/>
            </syncfusion:SfTreeView.Behaviors>
            <syncfusion:SfTreeView.ItemTemplate>
                <DataTemplate>
                    <Grid Padding="5,0,0,0">
                        <Label Text="{Binding Name}" 
                                   FontSize="Medium"
                                   VerticalTextAlignment="Center"/>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfTreeView.ItemTemplate>
        </syncfusion:SfTreeView>
    </ContentPage.Content>
```

### ViewModel

```csharp
public class CountriesViewModel : INotifyPropertyChanged
{
    public Command<ItemSelectionChangedEventArgs> selectionChangedCommand;

    public CountriesViewModel()
    {
        SelectionChangedCommand = new Command<Syncfusion.XForms.TreeView.ItemSelectionChangedEventArgs>(OnSelectionChanged);
        GenerateCountriesInfo();
    }

    public Command<ItemSelectionChangedEventArgs> SelectionChangedCommand
    {
        get { return selectionChangedCommand; }
        protected set { selectionChangedCommand = value; }
    }

    private void OnSelectionChanged(ItemSelectionChangedEventArgs obj)
    {
        App.Current.MainPage.DisplayAlert("Alert", (obj.AddedItems[0] as Countries).Name + " is selected", "OK");
    }
}
```

## Requirements to run the demo
Visual Studio 2017 or Visual Studio for Mac.
Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
