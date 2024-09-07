<a name='assembly'></a>
# PSU_OOP_CourseWork

## Contents

- [AnalyzedDish](#T-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish 'PSU_OOP_CourseWork.ViewModels.Source.AnalyzedDish')
  - [#ctor(Id,Name,Count)](#M-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-#ctor-System-Int32,System-String,System-Int32- 'PSU_OOP_CourseWork.ViewModels.Source.AnalyzedDish.#ctor(System.Int32,System.String,System.Int32)')
  - [Count](#P-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-Count 'PSU_OOP_CourseWork.ViewModels.Source.AnalyzedDish.Count')
  - [Id](#P-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-Id 'PSU_OOP_CourseWork.ViewModels.Source.AnalyzedDish.Id')
  - [Name](#P-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-Name 'PSU_OOP_CourseWork.ViewModels.Source.AnalyzedDish.Name')
- [App](#T-PSU_OOP_CourseWork-App 'PSU_OOP_CourseWork.App')
  - [Initialize()](#M-PSU_OOP_CourseWork-App-Initialize 'PSU_OOP_CourseWork.App.Initialize')
  - [OnFrameworkInitializationCompleted()](#M-PSU_OOP_CourseWork-App-OnFrameworkInitializationCompleted 'PSU_OOP_CourseWork.App.OnFrameworkInitializationCompleted')
- [ChartData](#T-PSU_OOP_CourseWork-ChartData-ChartData 'PSU_OOP_CourseWork.ChartData.ChartData')
  - [AddPopularityByDayOfWeek(plot,times)](#M-PSU_OOP_CourseWork-ChartData-ChartData-AddPopularityByDayOfWeek-ScottPlot-Plot,System-Collections-Generic-IEnumerable{System-DateTime}- 'PSU_OOP_CourseWork.ChartData.ChartData.AddPopularityByDayOfWeek(ScottPlot.Plot,System.Collections.Generic.IEnumerable{System.DateTime})')
  - [AddPopularityByHour(plot,times)](#M-PSU_OOP_CourseWork-ChartData-ChartData-AddPopularityByHour-ScottPlot-Plot,System-Collections-Generic-IEnumerable{System-DateTime}- 'PSU_OOP_CourseWork.ChartData.ChartData.AddPopularityByHour(ScottPlot.Plot,System.Collections.Generic.IEnumerable{System.DateTime})')
  - [AddPopularityByMonth(plot,times)](#M-PSU_OOP_CourseWork-ChartData-ChartData-AddPopularityByMonth-ScottPlot-Plot,System-Collections-Generic-IEnumerable{System-DateTime}- 'PSU_OOP_CourseWork.ChartData.ChartData.AddPopularityByMonth(ScottPlot.Plot,System.Collections.Generic.IEnumerable{System.DateTime})')
  - [PopularityBy\`\`1(times,selector)](#M-PSU_OOP_CourseWork-ChartData-ChartData-PopularityBy``1-System-Collections-Generic-IEnumerable{System-DateTime},System-Func{System-DateTime,``0}- 'PSU_OOP_CourseWork.ChartData.ChartData.PopularityBy``1(System.Collections.Generic.IEnumerable{System.DateTime},System.Func{System.DateTime,``0})')
- [CurrentTable](#T-PSU_OOP_CourseWork-Views-CurrentTable 'PSU_OOP_CourseWork.Views.CurrentTable')
- [Dish](#T-PSU_OOP_CourseWork-Models-Datums-Dish 'PSU_OOP_CourseWork.Models.Datums.Dish')
- [Dish](#T-PSU_OOP_CourseWork-ViewModels-Source-Dish 'PSU_OOP_CourseWork.ViewModels.Source.Dish')
  - [#ctor(Id,Name,Description,PriceRoubles)](#M-PSU_OOP_CourseWork-Models-Datums-Dish-#ctor-System-Int32,System-String,System-String,System-Decimal- 'PSU_OOP_CourseWork.Models.Datums.Dish.#ctor(System.Int32,System.String,System.String,System.Decimal)')
  - [#ctor(Id,Name,Description,PriceRoubles)](#M-PSU_OOP_CourseWork-ViewModels-Source-Dish-#ctor-System-Int32,System-String,System-String,System-Decimal- 'PSU_OOP_CourseWork.ViewModels.Source.Dish.#ctor(System.Int32,System.String,System.String,System.Decimal)')
  - [Description](#P-PSU_OOP_CourseWork-Models-Datums-Dish-Description 'PSU_OOP_CourseWork.Models.Datums.Dish.Description')
  - [Id](#P-PSU_OOP_CourseWork-Models-Datums-Dish-Id 'PSU_OOP_CourseWork.Models.Datums.Dish.Id')
  - [Name](#P-PSU_OOP_CourseWork-Models-Datums-Dish-Name 'PSU_OOP_CourseWork.Models.Datums.Dish.Name')
  - [PriceRoubles](#P-PSU_OOP_CourseWork-Models-Datums-Dish-PriceRoubles 'PSU_OOP_CourseWork.Models.Datums.Dish.PriceRoubles')
  - [Description](#P-PSU_OOP_CourseWork-ViewModels-Source-Dish-Description 'PSU_OOP_CourseWork.ViewModels.Source.Dish.Description')
  - [Id](#P-PSU_OOP_CourseWork-ViewModels-Source-Dish-Id 'PSU_OOP_CourseWork.ViewModels.Source.Dish.Id')
  - [Name](#P-PSU_OOP_CourseWork-ViewModels-Source-Dish-Name 'PSU_OOP_CourseWork.ViewModels.Source.Dish.Name')
  - [PriceRoubles](#P-PSU_OOP_CourseWork-ViewModels-Source-Dish-PriceRoubles 'PSU_OOP_CourseWork.ViewModels.Source.Dish.PriceRoubles')
- [DishAnalysisRow](#T-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow 'PSU_OOP_CourseWork.ViewModels.Rows.DishAnalysisRow')
  - [#ctor(Id,Name,OrdersCount)](#M-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-#ctor-System-Int32,System-String,System-Int32- 'PSU_OOP_CourseWork.ViewModels.Rows.DishAnalysisRow.#ctor(System.Int32,System.String,System.Int32)')
  - [Id](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-Id 'PSU_OOP_CourseWork.ViewModels.Rows.DishAnalysisRow.Id')
  - [Name](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-Name 'PSU_OOP_CourseWork.ViewModels.Rows.DishAnalysisRow.Name')
  - [OrdersCount](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-OrdersCount 'PSU_OOP_CourseWork.ViewModels.Rows.DishAnalysisRow.OrdersCount')
- [DishRow](#T-PSU_OOP_CourseWork-ViewModels-Rows-DishRow 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow')
  - [#ctor(id,name,description,priceRoubles,inCart)](#M-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-#ctor-System-Int32,System-String,System-String,System-Decimal,System-Int32- 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.#ctor(System.Int32,System.String,System.String,System.Decimal,System.Int32)')
  - [Description](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-Description 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.Description')
  - [FormattedPrice](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-FormattedPrice 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.FormattedPrice')
  - [Id](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-Id 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.Id')
  - [InCart](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-InCart 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.InCart')
  - [Name](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-Name 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.Name')
  - [PriceRoubles](#P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-PriceRoubles 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.PriceRoubles')
  - [FromSource(dish)](#M-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-FromSource-PSU_OOP_CourseWork-ViewModels-Source-Dish- 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow.FromSource(PSU_OOP_CourseWork.ViewModels.Source.Dish)')
- [Factory](#T-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory')
- [Factory](#T-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory 'PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory')
  - [#ctor(analysis)](#M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis- 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory.#ctor(PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis)')
  - [#ctor(onPlotReady)](#M-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory-#ctor-System-Action{ScottPlot-Plot}- 'PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory.#ctor(System.Action{ScottPlot.Plot})')
  - [Produce()](#M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory-Produce 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory.Produce')
  - [Produce()](#M-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory-Produce 'PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory.Produce')
- [IEnumerableExtension](#T-PSU_OOP_CourseWork-Util-IEnumerableExtension 'PSU_OOP_CourseWork.Util.IEnumerableExtension')
  - [AppendAll\`\`1(a,b)](#M-PSU_OOP_CourseWork-Util-IEnumerableExtension-AppendAll``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0}- 'PSU_OOP_CourseWork.Util.IEnumerableExtension.AppendAll``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})')
  - [WhereNotNull\`\`1(source)](#M-PSU_OOP_CourseWork-Util-IEnumerableExtension-WhereNotNull``1-System-Collections-Generic-IEnumerable{System-Nullable{``0}}- 'PSU_OOP_CourseWork.Util.IEnumerableExtension.WhereNotNull``1(System.Collections.Generic.IEnumerable{System.Nullable{``0}})')
- [IMenu](#T-PSU_OOP_CourseWork-Models-IMenu 'PSU_OOP_CourseWork.Models.IMenu')
- [IMenu](#T-PSU_OOP_CourseWork-ViewModels-Source-IMenu 'PSU_OOP_CourseWork.ViewModels.Source.IMenu')
  - [Items](#P-PSU_OOP_CourseWork-Models-IMenu-Items 'PSU_OOP_CourseWork.Models.IMenu.Items')
  - [Data](#P-PSU_OOP_CourseWork-ViewModels-Source-IMenu-Data 'PSU_OOP_CourseWork.ViewModels.Source.IMenu.Data')
  - [ChangePrice(id,priceRoubles)](#M-PSU_OOP_CourseWork-Models-IMenu-ChangePrice-System-Int32,System-Decimal- 'PSU_OOP_CourseWork.Models.IMenu.ChangePrice(System.Int32,System.Decimal)')
  - [Remove(id)](#M-PSU_OOP_CourseWork-Models-IMenu-Remove-System-Int32- 'PSU_OOP_CourseWork.Models.IMenu.Remove(System.Int32)')
- [IMenuAnalysis](#T-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis 'PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis')
  - [DishesStatsOnInterval](#P-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-DishesStatsOnInterval 'PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis.DishesStatsOnInterval')
  - [IntervalEnd](#P-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-IntervalEnd 'PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis.IntervalEnd')
  - [IntervalStart](#P-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-IntervalStart 'PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis.IntervalStart')
- [IOrders](#T-PSU_OOP_CourseWork-Models-IOrders 'PSU_OOP_CourseWork.Models.IOrders')
- [IOrders](#T-PSU_OOP_CourseWork-ViewModels-Source-IOrders 'PSU_OOP_CourseWork.ViewModels.Source.IOrders')
  - [Items](#P-PSU_OOP_CourseWork-Models-IOrders-Items 'PSU_OOP_CourseWork.Models.IOrders.Items')
  - [Data](#P-PSU_OOP_CourseWork-ViewModels-Source-IOrders-Data 'PSU_OOP_CourseWork.ViewModels.Source.IOrders.Data')
  - [Push(positions)](#M-PSU_OOP_CourseWork-Models-IOrders-Push-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-OrderPosition}- 'PSU_OOP_CourseWork.Models.IOrders.Push(System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.OrderPosition})')
  - [Remove(id)](#M-PSU_OOP_CourseWork-Models-IOrders-Remove-System-Int32- 'PSU_OOP_CourseWork.Models.IOrders.Remove(System.Int32)')
- [ISaveLoad](#T-PSU_OOP_CourseWork-Models-ISaveLoad 'PSU_OOP_CourseWork.Models.ISaveLoad')
  - [Load()](#M-PSU_OOP_CourseWork-Models-ISaveLoad-Load 'PSU_OOP_CourseWork.Models.ISaveLoad.Load')
  - [Save()](#M-PSU_OOP_CourseWork-Models-ISaveLoad-Save 'PSU_OOP_CourseWork.Models.ISaveLoad.Save')
- [ItemWithIndexDeconstruction](#T-PSU_OOP_CourseWork-Util-ItemWithIndexDeconstruction 'PSU_OOP_CourseWork.Util.ItemWithIndexDeconstruction')
  - [Deconstruct\`\`1(self,item,i)](#M-PSU_OOP_CourseWork-Util-ItemWithIndexDeconstruction-Deconstruct``1-DynamicData-Kernel-ItemWithIndex{``0},``0@,System-Int32@- 'PSU_OOP_CourseWork.Util.ItemWithIndexDeconstruction.Deconstruct``1(DynamicData.Kernel.ItemWithIndex{``0},``0@,System.Int32@)')
- [MainWindow](#T-PSU_OOP_CourseWork-Views-MainWindow 'PSU_OOP_CourseWork.Views.MainWindow')
  - [#ctor(madFactory,ordersChartByHourFactory,ordersChartByDayOfWeekFactory,ordersChartByMonthFactory)](#M-PSU_OOP_CourseWork-Views-MainWindow-#ctor-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory,PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory,PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory,PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory- 'PSU_OOP_CourseWork.Views.MainWindow.#ctor(PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory,PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory,PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory,PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory)')
  - [CurrentTable](#P-PSU_OOP_CourseWork-Views-MainWindow-CurrentTable 'PSU_OOP_CourseWork.Views.MainWindow.CurrentTable')
  - [DataContext](#P-PSU_OOP_CourseWork-Views-MainWindow-DataContext 'PSU_OOP_CourseWork.Views.MainWindow.DataContext')
  - [InitializeComponent(loadXaml,attachDevTools)](#M-PSU_OOP_CourseWork-Views-MainWindow-InitializeComponent-System-Boolean,System-Boolean- 'PSU_OOP_CourseWork.Views.MainWindow.InitializeComponent(System.Boolean,System.Boolean)')
- [MainWindowViewModel](#T-PSU_OOP_CourseWork-ViewModels-MainWindowViewModel 'PSU_OOP_CourseWork.ViewModels.MainWindowViewModel')
- [Menu](#T-PSU_OOP_CourseWork-ViewModelsModels-Menu 'PSU_OOP_CourseWork.ViewModelsModels.Menu')
- [Menu](#T-PSU_OOP_CourseWork-Views-Menu 'PSU_OOP_CourseWork.Views.Menu')
  - [#ctor(menu)](#M-PSU_OOP_CourseWork-ViewModelsModels-Menu-#ctor-PSU_OOP_CourseWork-Models-IMenu- 'PSU_OOP_CourseWork.ViewModelsModels.Menu.#ctor(PSU_OOP_CourseWork.Models.IMenu)')
  - [#ctor()](#M-PSU_OOP_CourseWork-Views-Menu-#ctor 'PSU_OOP_CourseWork.Views.Menu.#ctor')
  - [Data](#P-PSU_OOP_CourseWork-ViewModelsModels-Menu-Data 'PSU_OOP_CourseWork.ViewModelsModels.Menu.Data')
  - [DataContext](#P-PSU_OOP_CourseWork-Views-Menu-DataContext 'PSU_OOP_CourseWork.Views.Menu.DataContext')
  - [InitializeComponent(loadXaml)](#M-PSU_OOP_CourseWork-Views-Menu-InitializeComponent-System-Boolean- 'PSU_OOP_CourseWork.Views.Menu.InitializeComponent(System.Boolean)')
  - [OnPriceChanged(row)](#M-PSU_OOP_CourseWork-Views-Menu-OnPriceChanged-PSU_OOP_CourseWork-ViewModels-Rows-DishRow- 'PSU_OOP_CourseWork.Views.Menu.OnPriceChanged(PSU_OOP_CourseWork.ViewModels.Rows.DishRow)')
  - [Ready()](#M-PSU_OOP_CourseWork-Views-Menu-Ready 'PSU_OOP_CourseWork.Views.Menu.Ready')
  - [Remove(row)](#M-PSU_OOP_CourseWork-Views-Menu-Remove-PSU_OOP_CourseWork-ViewModels-Rows-DishRow- 'PSU_OOP_CourseWork.Views.Menu.Remove(PSU_OOP_CourseWork.ViewModels.Rows.DishRow)')
- [MenuAnalysis](#T-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis 'PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis')
  - [#ctor(orders,menu)](#M-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-#ctor-PSU_OOP_CourseWork-Models-IOrders,PSU_OOP_CourseWork-Models-IMenu- 'PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.#ctor(PSU_OOP_CourseWork.Models.IOrders,PSU_OOP_CourseWork.Models.IMenu)')
  - [DishesStatsOnInterval](#P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-DishesStatsOnInterval 'PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.DishesStatsOnInterval')
  - [IntervalEnd](#P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-IntervalEnd 'PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.IntervalEnd')
  - [IntervalStart](#P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-IntervalStart 'PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.IntervalStart')
- [MenuAnalysisDialog](#T-PSU_OOP_CourseWork-Views-MenuAnalysisDialog 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog')
  - [#ctor(dataContext)](#M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-#ctor-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel- 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog.#ctor(PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel)')
  - [DataContext](#P-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-DataContext 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog.DataContext')
  - [InitializeComponent(loadXaml,attachDevTools)](#M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-InitializeComponent-System-Boolean,System-Boolean- 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog.InitializeComponent(System.Boolean,System.Boolean)')
- [MenuAnalysisDialogViewModel](#T-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel 'PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel')
  - [#ctor(analysis)](#M-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis- 'PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel.#ctor(PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis)')
  - [EndDate](#P-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-EndDate 'PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel.EndDate')
  - [Rows](#P-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-Rows 'PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel.Rows')
  - [StartDate](#P-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-StartDate 'PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel.StartDate')
- [MenuViewModel](#T-PSU_OOP_CourseWork-ViewModels-MenuViewModel 'PSU_OOP_CourseWork.ViewModels.MenuViewModel')
  - [#ctor(menu)](#M-PSU_OOP_CourseWork-ViewModels-MenuViewModel-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IMenu- 'PSU_OOP_CourseWork.ViewModels.MenuViewModel.#ctor(PSU_OOP_CourseWork.ViewModels.Source.IMenu)')
  - [Rows](#P-PSU_OOP_CourseWork-ViewModels-MenuViewModel-Rows 'PSU_OOP_CourseWork.ViewModels.MenuViewModel.Rows')
- [ModelsDb](#T-PSU_OOP_CourseWork-ModelsDB-ModelsDb 'PSU_OOP_CourseWork.ModelsDB.ModelsDb')
  - [PSU_OOP_CourseWork#Models#IMenu#Items](#P-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IMenu#Items 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.PSU_OOP_CourseWork#Models#IMenu#Items')
  - [PSU_OOP_CourseWork#Models#IOrders#Items](#P-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IOrders#Items 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.PSU_OOP_CourseWork#Models#IOrders#Items')
  - [Load()](#M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-Load 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.Load')
  - [PSU_OOP_CourseWork#Models#IMenu#ChangePrice()](#M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IMenu#ChangePrice-System-Int32,System-Decimal- 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.PSU_OOP_CourseWork#Models#IMenu#ChangePrice(System.Int32,System.Decimal)')
  - [PSU_OOP_CourseWork#Models#IMenu#Remove()](#M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IMenu#Remove-System-Int32- 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.PSU_OOP_CourseWork#Models#IMenu#Remove(System.Int32)')
  - [PSU_OOP_CourseWork#Models#IOrders#Push()](#M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IOrders#Push-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-OrderPosition}- 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.PSU_OOP_CourseWork#Models#IOrders#Push(System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.OrderPosition})')
  - [PSU_OOP_CourseWork#Models#IOrders#Remove()](#M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IOrders#Remove-System-Int32- 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.PSU_OOP_CourseWork#Models#IOrders#Remove(System.Int32)')
  - [Save()](#M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-Save 'PSU_OOP_CourseWork.ModelsDB.ModelsDb.Save')
- [Order](#T-PSU_OOP_CourseWork-Models-Datums-Order 'PSU_OOP_CourseWork.Models.Datums.Order')
- [Order](#T-PSU_OOP_CourseWork-ViewModels-Source-Order 'PSU_OOP_CourseWork.ViewModels.Source.Order')
  - [#ctor(Id,Dishes,CostRoubles,DateTime)](#M-PSU_OOP_CourseWork-Models-Datums-Order-#ctor-System-Int32,System-Collections-Immutable-ImmutableArray{PSU_OOP_CourseWork-Models-Datums-OrderPosition},System-Decimal,System-DateTime- 'PSU_OOP_CourseWork.Models.Datums.Order.#ctor(System.Int32,System.Collections.Immutable.ImmutableArray{PSU_OOP_CourseWork.Models.Datums.OrderPosition},System.Decimal,System.DateTime)')
  - [#ctor(Id,Description,CostAtATimeRoubles,DateTime)](#M-PSU_OOP_CourseWork-ViewModels-Source-Order-#ctor-System-Int32,System-String,System-Decimal,System-DateTime- 'PSU_OOP_CourseWork.ViewModels.Source.Order.#ctor(System.Int32,System.String,System.Decimal,System.DateTime)')
  - [CostRoubles](#P-PSU_OOP_CourseWork-Models-Datums-Order-CostRoubles 'PSU_OOP_CourseWork.Models.Datums.Order.CostRoubles')
  - [DateTime](#P-PSU_OOP_CourseWork-Models-Datums-Order-DateTime 'PSU_OOP_CourseWork.Models.Datums.Order.DateTime')
  - [Dishes](#P-PSU_OOP_CourseWork-Models-Datums-Order-Dishes 'PSU_OOP_CourseWork.Models.Datums.Order.Dishes')
  - [Id](#P-PSU_OOP_CourseWork-Models-Datums-Order-Id 'PSU_OOP_CourseWork.Models.Datums.Order.Id')
  - [CostAtATimeRoubles](#P-PSU_OOP_CourseWork-ViewModels-Source-Order-CostAtATimeRoubles 'PSU_OOP_CourseWork.ViewModels.Source.Order.CostAtATimeRoubles')
  - [Date](#P-PSU_OOP_CourseWork-ViewModels-Source-Order-Date 'PSU_OOP_CourseWork.ViewModels.Source.Order.Date')
  - [DateTime](#P-PSU_OOP_CourseWork-ViewModels-Source-Order-DateTime 'PSU_OOP_CourseWork.ViewModels.Source.Order.DateTime')
  - [Description](#P-PSU_OOP_CourseWork-ViewModels-Source-Order-Description 'PSU_OOP_CourseWork.ViewModels.Source.Order.Description')
  - [Id](#P-PSU_OOP_CourseWork-ViewModels-Source-Order-Id 'PSU_OOP_CourseWork.ViewModels.Source.Order.Id')
  - [Time](#P-PSU_OOP_CourseWork-ViewModels-Source-Order-Time 'PSU_OOP_CourseWork.ViewModels.Source.Order.Time')
- [OrderPosition](#T-PSU_OOP_CourseWork-Models-Datums-OrderPosition 'PSU_OOP_CourseWork.Models.Datums.OrderPosition')
  - [#ctor(DishId,Quantity)](#M-PSU_OOP_CourseWork-Models-Datums-OrderPosition-#ctor-System-Int32,System-Int32- 'PSU_OOP_CourseWork.Models.Datums.OrderPosition.#ctor(System.Int32,System.Int32)')
  - [DishId](#P-PSU_OOP_CourseWork-Models-Datums-OrderPosition-DishId 'PSU_OOP_CourseWork.Models.Datums.OrderPosition.DishId')
  - [Quantity](#P-PSU_OOP_CourseWork-Models-Datums-OrderPosition-Quantity 'PSU_OOP_CourseWork.Models.Datums.OrderPosition.Quantity')
  - [FromKeyValue(kv)](#M-PSU_OOP_CourseWork-Models-Datums-OrderPosition-FromKeyValue-System-Collections-Generic-KeyValuePair{System-Int32,System-Int32}- 'PSU_OOP_CourseWork.Models.Datums.OrderPosition.FromKeyValue(System.Collections.Generic.KeyValuePair{System.Int32,System.Int32})')
- [OrderRow](#T-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow')
  - [#ctor(Id,Description,CostAtATimeRoubles,Time,Date)](#M-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-#ctor-System-Int32,System-String,System-Decimal,System-TimeOnly,System-DateOnly- 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.#ctor(System.Int32,System.String,System.Decimal,System.TimeOnly,System.DateOnly)')
  - [CostAtATimeRoubles](#P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-CostAtATimeRoubles 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.CostAtATimeRoubles')
  - [Date](#P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Date 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.Date')
  - [Description](#P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Description 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.Description')
  - [FormattedCost](#P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-FormattedCost 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.FormattedCost')
  - [FormattedDate](#P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-FormattedDate 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.FormattedDate')
  - [Id](#P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Id 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.Id')
  - [Time](#P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Time 'PSU_OOP_CourseWork.ViewModels.Rows.OrderRow.Time')
- [Orders](#T-PSU_OOP_CourseWork-ViewModelsModels-Orders 'PSU_OOP_CourseWork.ViewModelsModels.Orders')
- [Orders](#T-PSU_OOP_CourseWork-Views-Orders 'PSU_OOP_CourseWork.Views.Orders')
  - [#ctor(orders,menu)](#M-PSU_OOP_CourseWork-ViewModelsModels-Orders-#ctor-PSU_OOP_CourseWork-Models-IOrders,PSU_OOP_CourseWork-Models-IMenu- 'PSU_OOP_CourseWork.ViewModelsModels.Orders.#ctor(PSU_OOP_CourseWork.Models.IOrders,PSU_OOP_CourseWork.Models.IMenu)')
  - [#ctor()](#M-PSU_OOP_CourseWork-Views-Orders-#ctor 'PSU_OOP_CourseWork.Views.Orders.#ctor')
  - [Data](#P-PSU_OOP_CourseWork-ViewModelsModels-Orders-Data 'PSU_OOP_CourseWork.ViewModelsModels.Orders.Data')
  - [DataContext](#P-PSU_OOP_CourseWork-Views-Orders-DataContext 'PSU_OOP_CourseWork.Views.Orders.DataContext')
  - [InitializeComponent(loadXaml)](#M-PSU_OOP_CourseWork-Views-Orders-InitializeComponent-System-Boolean- 'PSU_OOP_CourseWork.Views.Orders.InitializeComponent(System.Boolean)')
  - [Remove(badRow)](#M-PSU_OOP_CourseWork-Views-Orders-Remove-System-Nullable{PSU_OOP_CourseWork-ViewModels-Rows-OrderRow}- 'PSU_OOP_CourseWork.Views.Orders.Remove(System.Nullable{PSU_OOP_CourseWork.ViewModels.Rows.OrderRow})')
- [OrdersViewModel](#T-PSU_OOP_CourseWork-ViewModels-OrdersViewModel 'PSU_OOP_CourseWork.ViewModels.OrdersViewModel')
  - [#ctor(orders)](#M-PSU_OOP_CourseWork-ViewModels-OrdersViewModel-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IOrders- 'PSU_OOP_CourseWork.ViewModels.OrdersViewModel.#ctor(PSU_OOP_CourseWork.ViewModels.Source.IOrders)')
  - [#ctor()](#M-PSU_OOP_CourseWork-ViewModels-OrdersViewModel-#ctor 'PSU_OOP_CourseWork.ViewModels.OrdersViewModel.#ctor')
  - [Rows](#P-PSU_OOP_CourseWork-ViewModels-OrdersViewModel-Rows 'PSU_OOP_CourseWork.ViewModels.OrdersViewModel.Rows')
- [ScottPlotDialog](#T-PSU_OOP_CourseWork-Views-ScottPlotDialog 'PSU_OOP_CourseWork.Views.ScottPlotDialog')
  - [#ctor()](#M-PSU_OOP_CourseWork-Views-ScottPlotDialog-#ctor 'PSU_OOP_CourseWork.Views.ScottPlotDialog.#ctor')
  - [#ctor(onPlotReady)](#M-PSU_OOP_CourseWork-Views-ScottPlotDialog-#ctor-System-Action{ScottPlot-Plot}- 'PSU_OOP_CourseWork.Views.ScottPlotDialog.#ctor(System.Action{ScottPlot.Plot})')
  - [InitializeComponent(loadXaml,attachDevTools)](#M-PSU_OOP_CourseWork-Views-ScottPlotDialog-InitializeComponent-System-Boolean,System-Boolean- 'PSU_OOP_CourseWork.Views.ScottPlotDialog.InitializeComponent(System.Boolean,System.Boolean)')
- [SqlService](#T-PSU_OOP_CourseWork-DB-SqlService 'PSU_OOP_CourseWork.DB.SqlService')
  - [#ctor()](#M-PSU_OOP_CourseWork-DB-SqlService-#ctor 'PSU_OOP_CourseWork.DB.SqlService.#ctor')
  - [Dishes](#P-PSU_OOP_CourseWork-DB-SqlService-Dishes 'PSU_OOP_CourseWork.DB.SqlService.Dishes')
  - [Orders](#P-PSU_OOP_CourseWork-DB-SqlService-Orders 'PSU_OOP_CourseWork.DB.SqlService.Orders')
  - [ChangeDishPrice(id,priceRoubles)](#M-PSU_OOP_CourseWork-DB-SqlService-ChangeDishPrice-System-Int32,System-Decimal- 'PSU_OOP_CourseWork.DB.SqlService.ChangeDishPrice(System.Int32,System.Decimal)')
  - [Load()](#M-PSU_OOP_CourseWork-DB-SqlService-Load 'PSU_OOP_CourseWork.DB.SqlService.Load')
  - [PushOrder(positions)](#M-PSU_OOP_CourseWork-DB-SqlService-PushOrder-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-OrderPosition}- 'PSU_OOP_CourseWork.DB.SqlService.PushOrder(System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.OrderPosition})')
  - [RemoveDish(id)](#M-PSU_OOP_CourseWork-DB-SqlService-RemoveDish-System-Int32- 'PSU_OOP_CourseWork.DB.SqlService.RemoveDish(System.Int32)')
  - [RemoveOrder(id)](#M-PSU_OOP_CourseWork-DB-SqlService-RemoveOrder-System-Int32- 'PSU_OOP_CourseWork.DB.SqlService.RemoveOrder(System.Int32)')
  - [Save()](#M-PSU_OOP_CourseWork-DB-SqlService-Save 'PSU_OOP_CourseWork.DB.SqlService.Save')
- [StringExtension](#T-PSU_OOP_CourseWork-Util-StringExtension 'PSU_OOP_CourseWork.Util.StringExtension')
  - [CoalesceEmpty(s)](#M-PSU_OOP_CourseWork-Util-StringExtension-CoalesceEmpty-System-String- 'PSU_OOP_CourseWork.Util.StringExtension.CoalesceEmpty(System.String)')
- [Stubs](#T-PSU_OOP_CourseWork-Models-Stubs-Stubs 'PSU_OOP_CourseWork.Models.Stubs.Stubs')
- [TimeExtension](#T-PSU_OOP_CourseWork-Util-TimeExtension 'PSU_OOP_CourseWork.Util.TimeExtension')
  - [AtLeast(dateTime,minConstraint)](#M-PSU_OOP_CourseWork-Util-TimeExtension-AtLeast-System-DateTime,System-DateTime- 'PSU_OOP_CourseWork.Util.TimeExtension.AtLeast(System.DateTime,System.DateTime)')
  - [Hours(hours)](#M-PSU_OOP_CourseWork-Util-TimeExtension-Hours-System-Int32- 'PSU_OOP_CourseWork.Util.TimeExtension.Hours(System.Int32)')
  - [OnlyDate(dateTime)](#M-PSU_OOP_CourseWork-Util-TimeExtension-OnlyDate-System-DateTime- 'PSU_OOP_CourseWork.Util.TimeExtension.OnlyDate(System.DateTime)')
  - [OnlyTime(dateTime)](#M-PSU_OOP_CourseWork-Util-TimeExtension-OnlyTime-System-DateTime- 'PSU_OOP_CourseWork.Util.TimeExtension.OnlyTime(System.DateTime)')
- [TransformedReadOnlyObservableCollection](#T-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection')
  - [TransformedToReadonly\`\`1(source)](#M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection-TransformedToReadonly``1-System-Collections-ObjectModel-ObservableCollection{``0}- 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection.TransformedToReadonly``1(System.Collections.ObjectModel.ObservableCollection{``0})')
  - [Transformed\`\`2(source,transformer)](#M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection-Transformed``2-System-Collections-ObjectModel-ReadOnlyObservableCollection{``0},System-Func{``0,``1}- 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection.Transformed``2(System.Collections.ObjectModel.ReadOnlyObservableCollection{``0},System.Func{``0,``1})')
  - [Transformed\`\`2(source,transformer)](#M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection-Transformed``2-System-Collections-ObjectModel-ObservableCollection{``0},System-Func{``0,``1}- 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection.Transformed``2(System.Collections.ObjectModel.ObservableCollection{``0},System.Func{``0,``1})')
- [TransformedReadOnlyObservableCollection\`2](#T-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection`2')
  - [#ctor(source,transformer)](#M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2-#ctor-System-Collections-ObjectModel-ReadOnlyObservableCollection{`0},System-Func{`0,`1}- 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection`2.#ctor(System.Collections.ObjectModel.ReadOnlyObservableCollection{`0},System.Func{`0,`1})')
  - [#ctor(source,transformer)](#M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2-#ctor-System-Collections-ObjectModel-ObservableCollection{`0},System-Func{`0,`1}- 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection`2.#ctor(System.Collections.ObjectModel.ObservableCollection{`0},System.Func{`0,`1})')
- [Util](#T-PSU_OOP_CourseWork-ViewModelsModels-Util 'PSU_OOP_CourseWork.ViewModelsModels.Util')
  - [FindById(source,id)](#M-PSU_OOP_CourseWork-ViewModelsModels-Util-FindById-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-Dish},System-Int32- 'PSU_OOP_CourseWork.ViewModelsModels.Util.FindById(System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.Dish},System.Int32)')
  - [FindById(source,id)](#M-PSU_OOP_CourseWork-ViewModelsModels-Util-FindById-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-Order},System-Int32- 'PSU_OOP_CourseWork.ViewModelsModels.Util.FindById(System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.Order},System.Int32)')
- [ViewLocator](#T-PSU_OOP_CourseWork-ViewLocator 'PSU_OOP_CourseWork.ViewLocator')
  - [Match()](#M-PSU_OOP_CourseWork-ViewLocator-Match-System-Object- 'PSU_OOP_CourseWork.ViewLocator.Match(System.Object)')
- [ViewModelBase](#T-PSU_OOP_CourseWork-ViewModels-ViewModelBase 'PSU_OOP_CourseWork.ViewModels.ViewModelBase')

<a name='T-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish'></a>
## AnalyzedDish `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Source

##### Summary

Представление блюда для Аналитики

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [T:PSU_OOP_CourseWork.ViewModels.Source.AnalyzedDish](#T-T-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish 'T:PSU_OOP_CourseWork.ViewModels.Source.AnalyzedDish') | Идентификатор блюда |

<a name='M-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-#ctor-System-Int32,System-String,System-Int32-'></a>
### #ctor(Id,Name,Count) `constructor`

##### Summary

Представление блюда для Аналитики

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор блюда |
| Name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Наименование блюда |
| Count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество заказов сего блюда |

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-Count'></a>
### Count `property`

##### Summary

Количество заказов сего блюда

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-Id'></a>
### Id `property`

##### Summary

Идентификатор блюда

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-AnalyzedDish-Name'></a>
### Name `property`

##### Summary

Наименование блюда

<a name='T-PSU_OOP_CourseWork-App'></a>
## App `type`

##### Namespace

PSU_OOP_CourseWork

##### Summary

*Inherit from parent.*

<a name='M-PSU_OOP_CourseWork-App-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-App-OnFrameworkInitializationCompleted'></a>
### OnFrameworkInitializationCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-PSU_OOP_CourseWork-ChartData-ChartData'></a>
## ChartData `type`

##### Namespace

PSU_OOP_CourseWork.ChartData

##### Summary

Класс для работы с графическими данными и их применением к графикам на ScottPlot.

<a name='M-PSU_OOP_CourseWork-ChartData-ChartData-AddPopularityByDayOfWeek-ScottPlot-Plot,System-Collections-Generic-IEnumerable{System-DateTime}-'></a>
### AddPopularityByDayOfWeek(plot,times) `method`

##### Summary

Добавляет график популярности по дням недели на указанный график.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| plot | [ScottPlot.Plot](#T-ScottPlot-Plot 'ScottPlot.Plot') | График, на который будет добавлен график популярности. |
| times | [System.Collections.Generic.IEnumerable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.DateTime}') | Список временных меток. |

<a name='M-PSU_OOP_CourseWork-ChartData-ChartData-AddPopularityByHour-ScottPlot-Plot,System-Collections-Generic-IEnumerable{System-DateTime}-'></a>
### AddPopularityByHour(plot,times) `method`

##### Summary

Добавляет график популярности по часам на указанный график.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| plot | [ScottPlot.Plot](#T-ScottPlot-Plot 'ScottPlot.Plot') | График, на который будет добавлен график популярности. |
| times | [System.Collections.Generic.IEnumerable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.DateTime}') | Список временных меток. |

<a name='M-PSU_OOP_CourseWork-ChartData-ChartData-AddPopularityByMonth-ScottPlot-Plot,System-Collections-Generic-IEnumerable{System-DateTime}-'></a>
### AddPopularityByMonth(plot,times) `method`

##### Summary

Добавляет график популярности по месяцам на указанный график.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| plot | [ScottPlot.Plot](#T-ScottPlot-Plot 'ScottPlot.Plot') | График, на который будет добавлен график популярности. |
| times | [System.Collections.Generic.IEnumerable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.DateTime}') | Список временных меток. |

<a name='M-PSU_OOP_CourseWork-ChartData-ChartData-PopularityBy``1-System-Collections-Generic-IEnumerable{System-DateTime},System-Func{System-DateTime,``0}-'></a>
### PopularityBy\`\`1(times,selector) `method`

##### Summary

Метод расширения для получения популярности по заданному ключу.

##### Returns

Список значений популярности в виде [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| times | [System.Collections.Generic.IEnumerable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.DateTime}') | Список временных меток. |
| selector | [System.Func{System.DateTime,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.DateTime,``0}') | Функция, выбирающая ключ из временной метки. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Тип ключа, по которому производится группировка. |

<a name='T-PSU_OOP_CourseWork-Views-CurrentTable'></a>
## CurrentTable `type`

##### Namespace

PSU_OOP_CourseWork.Views

##### Summary

Этот интерфейс выступает в роли идентификатора для класса, чтобы можно было его найти среди остальных элементов ui

<a name='T-PSU_OOP_CourseWork-Models-Datums-Dish'></a>
## Dish `type`

##### Namespace

PSU_OOP_CourseWork.Models.Datums

##### Summary

Представление блюда для области Models

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [T:PSU_OOP_CourseWork.Models.Datums.Dish](#T-T-PSU_OOP_CourseWork-Models-Datums-Dish 'T:PSU_OOP_CourseWork.Models.Datums.Dish') | Идентификатор блюда в БД |

<a name='T-PSU_OOP_CourseWork-ViewModels-Source-Dish'></a>
## Dish `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Source

##### Summary

Блюда

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [T:PSU_OOP_CourseWork.ViewModels.Source.Dish](#T-T-PSU_OOP_CourseWork-ViewModels-Source-Dish 'T:PSU_OOP_CourseWork.ViewModels.Source.Dish') | Идентификатор |

<a name='M-PSU_OOP_CourseWork-Models-Datums-Dish-#ctor-System-Int32,System-String,System-String,System-Decimal-'></a>
### #ctor(Id,Name,Description,PriceRoubles) `constructor`

##### Summary

Представление блюда для области Models

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор блюда в БД |
| Name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Название блюда |
| Description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Описание блюда |
| PriceRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Цена блюда в рублях |

<a name='M-PSU_OOP_CourseWork-ViewModels-Source-Dish-#ctor-System-Int32,System-String,System-String,System-Decimal-'></a>
### #ctor(Id,Name,Description,PriceRoubles) `constructor`

##### Summary

Блюда

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор |
| Name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Наименование |
| Description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Описание |
| PriceRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Цена в рублях |

<a name='P-PSU_OOP_CourseWork-Models-Datums-Dish-Description'></a>
### Description `property`

##### Summary

Описание блюда

<a name='P-PSU_OOP_CourseWork-Models-Datums-Dish-Id'></a>
### Id `property`

##### Summary

Идентификатор блюда в БД

<a name='P-PSU_OOP_CourseWork-Models-Datums-Dish-Name'></a>
### Name `property`

##### Summary

Название блюда

<a name='P-PSU_OOP_CourseWork-Models-Datums-Dish-PriceRoubles'></a>
### PriceRoubles `property`

##### Summary

Цена блюда в рублях

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Dish-Description'></a>
### Description `property`

##### Summary

Описание

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Dish-Id'></a>
### Id `property`

##### Summary

Идентификатор

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Dish-Name'></a>
### Name `property`

##### Summary

Наименование

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Dish-PriceRoubles'></a>
### PriceRoubles `property`

##### Summary

Цена в рублях

<a name='T-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow'></a>
## DishAnalysisRow `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Rows

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [T:PSU_OOP_CourseWork.ViewModels.Rows.DishAnalysisRow](#T-T-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow 'T:PSU_OOP_CourseWork.ViewModels.Rows.DishAnalysisRow') |  |

<a name='M-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-#ctor-System-Int32,System-String,System-Int32-'></a>
### #ctor(Id,Name,OrdersCount) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| Name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| OrdersCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-Id'></a>
### Id `property`

##### Summary



<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-Name'></a>
### Name `property`

##### Summary



<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishAnalysisRow-OrdersCount'></a>
### OrdersCount `property`

##### Summary



<a name='T-PSU_OOP_CourseWork-ViewModels-Rows-DishRow'></a>
## DishRow `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Rows

##### Summary

Отображаемое в ui блюдо

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [T:PSU_OOP_CourseWork.ViewModels.Rows.DishRow](#T-T-PSU_OOP_CourseWork-ViewModels-Rows-DishRow 'T:PSU_OOP_CourseWork.ViewModels.Rows.DishRow') | Идентификатор |

<a name='M-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-#ctor-System-Int32,System-String,System-String,System-Decimal,System-Int32-'></a>
### #ctor(id,name,description,priceRoubles,inCart) `constructor`

##### Summary

Отображаемое в ui блюдо

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Наименование |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Описание |
| priceRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Цена в рублях |
| inCart | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | В корзине? |

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-Description'></a>
### Description `property`

##### Summary

Описание

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-FormattedPrice'></a>
### FormattedPrice `property`

##### Summary

Форматированная цена

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-Id'></a>
### Id `property`

##### Summary

Идентификатор

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-InCart'></a>
### InCart `property`

##### Summary

В корзине?

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-Name'></a>
### Name `property`

##### Summary

Наименование

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-PriceRoubles'></a>
### PriceRoubles `property`

##### Summary

Цена в рублях

<a name='M-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-FromSource-PSU_OOP_CourseWork-ViewModels-Source-Dish-'></a>
### FromSource(dish) `method`

##### Summary

Фабричный метод конвертации из модельного слоя

##### Returns

Блюдо

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dish | [PSU_OOP_CourseWork.ViewModels.Source.Dish](#T-PSU_OOP_CourseWork-ViewModels-Source-Dish 'PSU_OOP_CourseWork.ViewModels.Source.Dish') | Блюдо в слое модели |

<a name='T-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory'></a>
## Factory `type`

##### Namespace

PSU_OOP_CourseWork.Views.MenuAnalysisDialog

##### Summary

Фабрица диалога аналитики меню

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| analysis | [T:PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory](#T-T-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory 'T:PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory') |  |

<a name='T-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory'></a>
## Factory `type`

##### Namespace

PSU_OOP_CourseWork.Views.ScottPlotDialog

##### Summary

Фабрика диалоговых окон графиков

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onPlotReady | [T:PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory](#T-T-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory 'T:PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory') |  |

<a name='M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-'></a>
### #ctor(analysis) `constructor`

##### Summary

Фабрица диалога аналитики меню

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| analysis | [PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis](#T-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis 'PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis') |  |

<a name='M-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory-#ctor-System-Action{ScottPlot-Plot}-'></a>
### #ctor(onPlotReady) `constructor`

##### Summary

Фабрика диалоговых окон графиков

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onPlotReady | [System.Action{ScottPlot.Plot}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{ScottPlot.Plot}') |  |

<a name='M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory-Produce'></a>
### Produce() `method`

##### Summary

Создание продукта фабрики

##### Returns

MenuAnalysisDialog

##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory-Produce'></a>
### Produce() `method`

##### Summary

Создаёт диалоговое окно графиков

##### Returns



##### Parameters

This method has no parameters.

<a name='T-PSU_OOP_CourseWork-Util-IEnumerableExtension'></a>
## IEnumerableExtension `type`

##### Namespace

PSU_OOP_CourseWork.Util

##### Summary

Расширения для IEnumerable

<a name='M-PSU_OOP_CourseWork-Util-IEnumerableExtension-AppendAll``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### AppendAll\`\`1(a,b) `method`

##### Summary

Создаёт новый IEnumerable, имеющий данные подряд из a и из b

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') |  |
| b | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-PSU_OOP_CourseWork-Util-IEnumerableExtension-WhereNotNull``1-System-Collections-Generic-IEnumerable{System-Nullable{``0}}-'></a>
### WhereNotNull\`\`1(source) `method`

##### Summary

Отфильтровывает элементы == null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.Nullable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Nullable{``0}}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-PSU_OOP_CourseWork-Models-IMenu'></a>
## IMenu `type`

##### Namespace

PSU_OOP_CourseWork.Models

##### Summary

Интерфейс для представления меню, его блюда и интерфейс работы с ними.

<a name='T-PSU_OOP_CourseWork-ViewModels-Source-IMenu'></a>
## IMenu `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Source

##### Summary

Интерфейс для подписи на блюда меню

<a name='P-PSU_OOP_CourseWork-Models-IMenu-Items'></a>
### Items `property`

##### Summary

Коллекция блюд в меню.

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-IMenu-Data'></a>
### Data `property`

##### Summary

Автообновляемые блюда в меню

<a name='M-PSU_OOP_CourseWork-Models-IMenu-ChangePrice-System-Int32,System-Decimal-'></a>
### ChangePrice(id,priceRoubles) `method`

##### Summary

Изменяет цену блюда по заданному идентификатору.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор блюда, цену которого необходимо изменить. |
| priceRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Новая цена блюда в рублях. |

<a name='M-PSU_OOP_CourseWork-Models-IMenu-Remove-System-Int32-'></a>
### Remove(id) `method`

##### Summary

Удаляет блюдо из меню по заданному идентификатору.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор блюда, которое необходимо удалить. |

<a name='T-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis'></a>
## IMenuAnalysis `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Source

##### Summary

Интерфейс источника аналитических данных о блюдах

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-DishesStatsOnInterval'></a>
### DishesStatsOnInterval `property`

##### Summary

Аналитические данные о блюдах на отрезке времени

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-IntervalEnd'></a>
### IntervalEnd `property`

##### Summary

Дата конца отрезка просмотра статистики

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-IntervalStart'></a>
### IntervalStart `property`

##### Summary

Дата начала отрезка просмотра статистики

<a name='T-PSU_OOP_CourseWork-Models-IOrders'></a>
## IOrders `type`

##### Namespace

PSU_OOP_CourseWork.Models

##### Summary

Интерфейс для представления заказов и работы с ними

<a name='T-PSU_OOP_CourseWork-ViewModels-Source-IOrders'></a>
## IOrders `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Source

##### Summary

Интерфейс для подписи на заказы

<a name='P-PSU_OOP_CourseWork-Models-IOrders-Items'></a>
### Items `property`

##### Summary

Заказы

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-IOrders-Data'></a>
### Data `property`

##### Summary

Автообновляемые заказы

<a name='M-PSU_OOP_CourseWork-Models-IOrders-Push-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-OrderPosition}-'></a>
### Push(positions) `method`

##### Summary

Добавление нового заказа

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| positions | [System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.OrderPosition}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.OrderPosition}') | Позиции блюд, указанные в заказе |

<a name='M-PSU_OOP_CourseWork-Models-IOrders-Remove-System-Int32-'></a>
### Remove(id) `method`

##### Summary

Удаление заказа по идентификатору

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор заказа |

<a name='T-PSU_OOP_CourseWork-Models-ISaveLoad'></a>
## ISaveLoad `type`

##### Namespace

PSU_OOP_CourseWork.Models

##### Summary

Интерфейс для работы с Сохранением/Загрузкой

<a name='M-PSU_OOP_CourseWork-Models-ISaveLoad-Load'></a>
### Load() `method`

##### Summary

Загрузка данных

##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-Models-ISaveLoad-Save'></a>
### Save() `method`

##### Summary

Выгрузка данных

##### Parameters

This method has no parameters.

<a name='T-PSU_OOP_CourseWork-Util-ItemWithIndexDeconstruction'></a>
## ItemWithIndexDeconstruction `type`

##### Namespace

PSU_OOP_CourseWork.Util

##### Summary

Расширяющий класс для разборки структуры ItemWithIndex

<a name='M-PSU_OOP_CourseWork-Util-ItemWithIndexDeconstruction-Deconstruct``1-DynamicData-Kernel-ItemWithIndex{``0},``0@,System-Int32@-'></a>
### Deconstruct\`\`1(self,item,i) `method`

##### Summary

Деконструктор

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [DynamicData.Kernel.ItemWithIndex{\`\`0}](#T-DynamicData-Kernel-ItemWithIndex{``0} 'DynamicData.Kernel.ItemWithIndex{``0}') | Деконструируимое |
| item | [\`\`0@](#T-``0@ '``0@') | Элемент |
| i | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Индекс |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип элемента |

<a name='T-PSU_OOP_CourseWork-Views-MainWindow'></a>
## MainWindow `type`

##### Namespace

PSU_OOP_CourseWork.Views

##### Summary

Окно

<a name='M-PSU_OOP_CourseWork-Views-MainWindow-#ctor-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory,PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory,PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory,PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory-'></a>
### #ctor(madFactory,ordersChartByHourFactory,ordersChartByDayOfWeekFactory,ordersChartByMonthFactory) `constructor`

##### Summary

Полный конструктор основного окна

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| madFactory | [PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory](#T-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-Factory 'PSU_OOP_CourseWork.Views.MenuAnalysisDialog.Factory') | Безумная фабрика |
| ordersChartByHourFactory | [PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory](#T-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory 'PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory') | Фабрика диалога с графиком по часам |
| ordersChartByDayOfWeekFactory | [PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory](#T-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory 'PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory') | Фабрика диалога с графиком по дням недели |
| ordersChartByMonthFactory | [PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory](#T-PSU_OOP_CourseWork-Views-ScottPlotDialog-Factory 'PSU_OOP_CourseWork.Views.ScottPlotDialog.Factory') | Фабрика диалога с графиком заказов по месяцам |

<a name='P-PSU_OOP_CourseWork-Views-MainWindow-CurrentTable'></a>
### CurrentTable `property`

##### Summary

Выбранная в данный момент таблица

<a name='P-PSU_OOP_CourseWork-Views-MainWindow-DataContext'></a>
### DataContext `property`

##### Summary

Данные ViewModel'и

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | TODO assign in App.axaml.cs |

<a name='M-PSU_OOP_CourseWork-Views-MainWindow-InitializeComponent-System-Boolean,System-Boolean-'></a>
### InitializeComponent(loadXaml,attachDevTools) `method`

##### Summary

Wires up the controls and optionally loads XAML markup and attaches dev tools (if Avalonia.Diagnostics package is referenced).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loadXaml | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the XAML be loaded into the component. |
| attachDevTools | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the dev tools be attached. |

<a name='T-PSU_OOP_CourseWork-ViewModels-MainWindowViewModel'></a>
## MainWindowViewModel `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels

##### Summary

ViewModel основного окна

<a name='T-PSU_OOP_CourseWork-ViewModelsModels-Menu'></a>
## Menu `type`

##### Namespace

PSU_OOP_CourseWork.ViewModelsModels

##### Summary

Адаптер модели меню для viewmodel'ного слоя

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menu | [T:PSU_OOP_CourseWork.ViewModelsModels.Menu](#T-T-PSU_OOP_CourseWork-ViewModelsModels-Menu 'T:PSU_OOP_CourseWork.ViewModelsModels.Menu') |  |

<a name='T-PSU_OOP_CourseWork-Views-Menu'></a>
## Menu `type`

##### Namespace

PSU_OOP_CourseWork.Views

##### Summary

Меню ui

<a name='M-PSU_OOP_CourseWork-ViewModelsModels-Menu-#ctor-PSU_OOP_CourseWork-Models-IMenu-'></a>
### #ctor(menu) `constructor`

##### Summary

Адаптер модели меню для viewmodel'ного слоя

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menu | [PSU_OOP_CourseWork.Models.IMenu](#T-PSU_OOP_CourseWork-Models-IMenu 'PSU_OOP_CourseWork.Models.IMenu') |  |

<a name='M-PSU_OOP_CourseWork-Views-Menu-#ctor'></a>
### #ctor() `constructor`

##### Summary

Пустой конструктор

##### Parameters

This constructor has no parameters.

<a name='P-PSU_OOP_CourseWork-ViewModelsModels-Menu-Data'></a>
### Data `property`

##### Summary

Блюда

<a name='P-PSU_OOP_CourseWork-Views-Menu-DataContext'></a>
### DataContext `property`

##### Summary

Модель данных меню

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-PSU_OOP_CourseWork-Views-Menu-InitializeComponent-System-Boolean-'></a>
### InitializeComponent(loadXaml) `method`

##### Summary

Wires up the controls and optionally loads XAML markup and attaches dev tools (if Avalonia.Diagnostics package is referenced).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loadXaml | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the XAML be loaded into the component. |

<a name='M-PSU_OOP_CourseWork-Views-Menu-OnPriceChanged-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-'></a>
### OnPriceChanged(row) `method`

##### Summary

Метод изменения цены со стороны ui в направление данных

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| row | [PSU_OOP_CourseWork.ViewModels.Rows.DishRow](#T-PSU_OOP_CourseWork-ViewModels-Rows-DishRow 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow') | Изменённая строка |

<a name='M-PSU_OOP_CourseWork-Views-Menu-Ready'></a>
### Ready() `method`

##### Summary

Метод для инициализации, когда все источники данных уже актины

##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-Views-Menu-Remove-PSU_OOP_CourseWork-ViewModels-Rows-DishRow-'></a>
### Remove(row) `method`

##### Summary

NotUsed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| row | [PSU_OOP_CourseWork.ViewModels.Rows.DishRow](#T-PSU_OOP_CourseWork-ViewModels-Rows-DishRow 'PSU_OOP_CourseWork.ViewModels.Rows.DishRow') |  |

<a name='T-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis'></a>
## MenuAnalysis `type`

##### Namespace

PSU_OOP_CourseWork.ViewModelsModels

##### Summary

Адаптер модели аналитики меню для viewmodel'ного слоя

<a name='M-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-#ctor-PSU_OOP_CourseWork-Models-IOrders,PSU_OOP_CourseWork-Models-IMenu-'></a>
### #ctor(orders,menu) `constructor`

##### Summary

Конструктор анализатора меню из модели заказов и модели меню

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orders | [PSU_OOP_CourseWork.Models.IOrders](#T-PSU_OOP_CourseWork-Models-IOrders 'PSU_OOP_CourseWork.Models.IOrders') | Модель заказов |
| menu | [PSU_OOP_CourseWork.Models.IMenu](#T-PSU_OOP_CourseWork-Models-IMenu 'PSU_OOP_CourseWork.Models.IMenu') | Модель меню |

<a name='P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-DishesStatsOnInterval'></a>
### DishesStatsOnInterval `property`

##### Summary

Блюда на отрезке времени

##### See Also

- [PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.IntervalStart](#P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-IntervalStart 'PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.IntervalStart')
- [PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.IntervalEnd](#P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-IntervalEnd 'PSU_OOP_CourseWork.ViewModelsModels.MenuAnalysis.IntervalEnd')

<a name='P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-IntervalEnd'></a>
### IntervalEnd `property`

##### Summary

Конец отрезка времени для данных аналитики

<a name='P-PSU_OOP_CourseWork-ViewModelsModels-MenuAnalysis-IntervalStart'></a>
### IntervalStart `property`

##### Summary

Начало отрезка времени для данных аналитики

<a name='T-PSU_OOP_CourseWork-Views-MenuAnalysisDialog'></a>
## MenuAnalysisDialog `type`

##### Namespace

PSU_OOP_CourseWork.Views

##### Summary

Диалог аналитики меню

<a name='M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-#ctor-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-'></a>
### #ctor(dataContext) `constructor`

##### Summary

Конструктор с ViewModel

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel](#T-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel 'PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel') |  |

<a name='P-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-DataContext'></a>
### DataContext `property`

##### Summary

ViewModel

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-PSU_OOP_CourseWork-Views-MenuAnalysisDialog-InitializeComponent-System-Boolean,System-Boolean-'></a>
### InitializeComponent(loadXaml,attachDevTools) `method`

##### Summary

Wires up the controls and optionally loads XAML markup and attaches dev tools (if Avalonia.Diagnostics package is referenced).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loadXaml | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the XAML be loaded into the component. |
| attachDevTools | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the dev tools be attached. |

<a name='T-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel'></a>
## MenuAnalysisDialogViewModel `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| analysis | [T:PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel](#T-T-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel 'T:PSU_OOP_CourseWork.ViewModels.MenuAnalysisDialogViewModel') |  |

<a name='M-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis-'></a>
### #ctor(analysis) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| analysis | [PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis](#T-PSU_OOP_CourseWork-ViewModels-Source-IMenuAnalysis 'PSU_OOP_CourseWork.ViewModels.Source.IMenuAnalysis') |  |

<a name='P-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-EndDate'></a>
### EndDate `property`

##### Summary

Дата конца отрезка рассматриваемых данных

<a name='P-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-Rows'></a>
### Rows `property`

##### Summary

Аналитические данные о блюдах

<a name='P-PSU_OOP_CourseWork-ViewModels-MenuAnalysisDialogViewModel-StartDate'></a>
### StartDate `property`

##### Summary

Дата начала отрезка рассматриваемых данных

<a name='T-PSU_OOP_CourseWork-ViewModels-MenuViewModel'></a>
## MenuViewModel `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels

##### Summary

ViewModel Меню

<a name='M-PSU_OOP_CourseWork-ViewModels-MenuViewModel-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IMenu-'></a>
### #ctor(menu) `constructor`

##### Summary

Конструктор обозреваемых блюд из модели

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menu | [PSU_OOP_CourseWork.ViewModels.Source.IMenu](#T-PSU_OOP_CourseWork-ViewModels-Source-IMenu 'PSU_OOP_CourseWork.ViewModels.Source.IMenu') |  |

<a name='P-PSU_OOP_CourseWork-ViewModels-MenuViewModel-Rows'></a>
### Rows `property`

##### Summary

Отображаемые в табоице блюда

<a name='T-PSU_OOP_CourseWork-ModelsDB-ModelsDb'></a>
## ModelsDb `type`

##### Namespace

PSU_OOP_CourseWork.ModelsDB

##### Summary

Мост меж слоями БД и Модели

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [T:PSU_OOP_CourseWork.ModelsDB.ModelsDb](#T-T-PSU_OOP_CourseWork-ModelsDB-ModelsDb 'T:PSU_OOP_CourseWork.ModelsDB.ModelsDb') |  |

<a name='P-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IMenu#Items'></a>
### PSU_OOP_CourseWork#Models#IMenu#Items `property`

##### Summary



<a name='P-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IOrders#Items'></a>
### PSU_OOP_CourseWork#Models#IOrders#Items `property`

##### Summary



<a name='M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-Load'></a>
### Load() `method`

##### Summary



##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IMenu#ChangePrice-System-Int32,System-Decimal-'></a>
### PSU_OOP_CourseWork#Models#IMenu#ChangePrice() `method`

##### Summary



##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IMenu#Remove-System-Int32-'></a>
### PSU_OOP_CourseWork#Models#IMenu#Remove() `method`

##### Summary



##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IOrders#Push-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-OrderPosition}-'></a>
### PSU_OOP_CourseWork#Models#IOrders#Push() `method`

##### Summary



##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-PSU_OOP_CourseWork#Models#IOrders#Remove-System-Int32-'></a>
### PSU_OOP_CourseWork#Models#IOrders#Remove() `method`

##### Summary



##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-ModelsDB-ModelsDb-Save'></a>
### Save() `method`

##### Summary



##### Parameters

This method has no parameters.

<a name='T-PSU_OOP_CourseWork-Models-Datums-Order'></a>
## Order `type`

##### Namespace

PSU_OOP_CourseWork.Models.Datums

##### Summary

Представление заказа для области Models

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [T:PSU_OOP_CourseWork.Models.Datums.Order](#T-T-PSU_OOP_CourseWork-Models-Datums-Order 'T:PSU_OOP_CourseWork.Models.Datums.Order') | Идентификатор заказа в БД |

<a name='T-PSU_OOP_CourseWork-ViewModels-Source-Order'></a>
## Order `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Source

##### Summary

Заказ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [T:PSU_OOP_CourseWork.ViewModels.Source.Order](#T-T-PSU_OOP_CourseWork-ViewModels-Source-Order 'T:PSU_OOP_CourseWork.ViewModels.Source.Order') | Идентификатор |

<a name='M-PSU_OOP_CourseWork-Models-Datums-Order-#ctor-System-Int32,System-Collections-Immutable-ImmutableArray{PSU_OOP_CourseWork-Models-Datums-OrderPosition},System-Decimal,System-DateTime-'></a>
### #ctor(Id,Dishes,CostRoubles,DateTime) `constructor`

##### Summary

Представление заказа для области Models

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор заказа в БД |
| Dishes | [System.Collections.Immutable.ImmutableArray{PSU_OOP_CourseWork.Models.Datums.OrderPosition}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Immutable.ImmutableArray 'System.Collections.Immutable.ImmutableArray{PSU_OOP_CourseWork.Models.Datums.OrderPosition}') | Блюда, указанные при заказе |
| CostRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Стоимость на момент оформления |
| DateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Дата и время оформления |

<a name='M-PSU_OOP_CourseWork-ViewModels-Source-Order-#ctor-System-Int32,System-String,System-Decimal,System-DateTime-'></a>
### #ctor(Id,Description,CostAtATimeRoubles,DateTime) `constructor`

##### Summary

Заказ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор |
| Description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Описание |
| CostAtATimeRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Стоимость во время заказа |
| DateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Дата и время заказа |

<a name='P-PSU_OOP_CourseWork-Models-Datums-Order-CostRoubles'></a>
### CostRoubles `property`

##### Summary

Стоимость на момент оформления

<a name='P-PSU_OOP_CourseWork-Models-Datums-Order-DateTime'></a>
### DateTime `property`

##### Summary

Дата и время оформления

<a name='P-PSU_OOP_CourseWork-Models-Datums-Order-Dishes'></a>
### Dishes `property`

##### Summary

Блюда, указанные при заказе

<a name='P-PSU_OOP_CourseWork-Models-Datums-Order-Id'></a>
### Id `property`

##### Summary

Идентификатор заказа в БД

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Order-CostAtATimeRoubles'></a>
### CostAtATimeRoubles `property`

##### Summary

Стоимость во время заказа

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Order-Date'></a>
### Date `property`

##### Summary

Дата заказа

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Order-DateTime'></a>
### DateTime `property`

##### Summary

Дата и время заказа

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Order-Description'></a>
### Description `property`

##### Summary

Описание

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Order-Id'></a>
### Id `property`

##### Summary

Идентификатор

<a name='P-PSU_OOP_CourseWork-ViewModels-Source-Order-Time'></a>
### Time `property`

##### Summary

Время заказа

<a name='T-PSU_OOP_CourseWork-Models-Datums-OrderPosition'></a>
## OrderPosition `type`

##### Namespace

PSU_OOP_CourseWork.Models.Datums

##### Summary

Позиция заказанного блюда с его количеством в заказе

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| DishId | [T:PSU_OOP_CourseWork.Models.Datums.OrderPosition](#T-T-PSU_OOP_CourseWork-Models-Datums-OrderPosition 'T:PSU_OOP_CourseWork.Models.Datums.OrderPosition') | Идентификатор заказанного блюда |

<a name='M-PSU_OOP_CourseWork-Models-Datums-OrderPosition-#ctor-System-Int32,System-Int32-'></a>
### #ctor(DishId,Quantity) `constructor`

##### Summary

Позиция заказанного блюда с его количеством в заказе

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| DishId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор заказанного блюда |
| Quantity | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество заказанных порций |

<a name='P-PSU_OOP_CourseWork-Models-Datums-OrderPosition-DishId'></a>
### DishId `property`

##### Summary

Идентификатор заказанного блюда

<a name='P-PSU_OOP_CourseWork-Models-Datums-OrderPosition-Quantity'></a>
### Quantity `property`

##### Summary

Количество заказанных порций

<a name='M-PSU_OOP_CourseWork-Models-Datums-OrderPosition-FromKeyValue-System-Collections-Generic-KeyValuePair{System-Int32,System-Int32}-'></a>
### FromKeyValue(kv) `method`

##### Summary

Фабричный метод создающий Позицию Заказа из generic структуры KeyValuePair

##### Returns

Позицию Заказа построенную на базе входящей пары

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| kv | [System.Collections.Generic.KeyValuePair{System.Int32,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair 'System.Collections.Generic.KeyValuePair{System.Int32,System.Int32}') | [int dishId] = (int quantity) |

<a name='T-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow'></a>
## OrderRow `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels.Rows

##### Summary

Заказ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [T:PSU_OOP_CourseWork.ViewModels.Rows.OrderRow](#T-T-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow 'T:PSU_OOP_CourseWork.ViewModels.Rows.OrderRow') | Идентификатор |

<a name='M-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-#ctor-System-Int32,System-String,System-Decimal,System-TimeOnly,System-DateOnly-'></a>
### #ctor(Id,Description,CostAtATimeRoubles,Time,Date) `constructor`

##### Summary

Заказ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор |
| Description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Описание |
| CostAtATimeRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Цена во время заказа в рублях |
| Time | [System.TimeOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeOnly 'System.TimeOnly') | Время заказа |
| Date | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Дата заказа |

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-CostAtATimeRoubles'></a>
### CostAtATimeRoubles `property`

##### Summary

Цена во время заказа в рублях

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Date'></a>
### Date `property`

##### Summary

Дата заказа

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Description'></a>
### Description `property`

##### Summary

Описание

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-FormattedCost'></a>
### FormattedCost `property`

##### Summary

Отформатированная цена

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-FormattedDate'></a>
### FormattedDate `property`

##### Summary

Отформатированная дата

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Id'></a>
### Id `property`

##### Summary

Идентификатор

<a name='P-PSU_OOP_CourseWork-ViewModels-Rows-OrderRow-Time'></a>
### Time `property`

##### Summary

Время заказа

<a name='T-PSU_OOP_CourseWork-ViewModelsModels-Orders'></a>
## Orders `type`

##### Namespace

PSU_OOP_CourseWork.ViewModelsModels

##### Summary

Адаптер заказов из модельного слоя во viewmodel'ный

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orders | [T:PSU_OOP_CourseWork.ViewModelsModels.Orders](#T-T-PSU_OOP_CourseWork-ViewModelsModels-Orders 'T:PSU_OOP_CourseWork.ViewModelsModels.Orders') |  |

<a name='T-PSU_OOP_CourseWork-Views-Orders'></a>
## Orders `type`

##### Namespace

PSU_OOP_CourseWork.Views

##### Summary

UI Заказы

<a name='M-PSU_OOP_CourseWork-ViewModelsModels-Orders-#ctor-PSU_OOP_CourseWork-Models-IOrders,PSU_OOP_CourseWork-Models-IMenu-'></a>
### #ctor(orders,menu) `constructor`

##### Summary

Адаптер заказов из модельного слоя во viewmodel'ный

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orders | [PSU_OOP_CourseWork.Models.IOrders](#T-PSU_OOP_CourseWork-Models-IOrders 'PSU_OOP_CourseWork.Models.IOrders') |  |
| menu | [PSU_OOP_CourseWork.Models.IMenu](#T-PSU_OOP_CourseWork-Models-IMenu 'PSU_OOP_CourseWork.Models.IMenu') |  |

<a name='M-PSU_OOP_CourseWork-Views-Orders-#ctor'></a>
### #ctor() `constructor`

##### Summary

Заказы

##### Parameters

This constructor has no parameters.

<a name='P-PSU_OOP_CourseWork-ViewModelsModels-Orders-Data'></a>
### Data `property`

##### Summary

Ресформированные заказы

<a name='P-PSU_OOP_CourseWork-Views-Orders-DataContext'></a>
### DataContext `property`

##### Summary

ViewModel

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-PSU_OOP_CourseWork-Views-Orders-InitializeComponent-System-Boolean-'></a>
### InitializeComponent(loadXaml) `method`

##### Summary

Wires up the controls and optionally loads XAML markup and attaches dev tools (if Avalonia.Diagnostics package is referenced).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loadXaml | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the XAML be loaded into the component. |

<a name='M-PSU_OOP_CourseWork-Views-Orders-Remove-System-Nullable{PSU_OOP_CourseWork-ViewModels-Rows-OrderRow}-'></a>
### Remove(badRow) `method`

##### Summary

Deprecated

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| badRow | [System.Nullable{PSU_OOP_CourseWork.ViewModels.Rows.OrderRow}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{PSU_OOP_CourseWork.ViewModels.Rows.OrderRow}') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='T-PSU_OOP_CourseWork-ViewModels-OrdersViewModel'></a>
## OrdersViewModel `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels

##### Summary

ViewModel Заказов

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orders | [T:PSU_OOP_CourseWork.ViewModels.OrdersViewModel](#T-T-PSU_OOP_CourseWork-ViewModels-OrdersViewModel 'T:PSU_OOP_CourseWork.ViewModels.OrdersViewModel') | Модель заказов |

<a name='M-PSU_OOP_CourseWork-ViewModels-OrdersViewModel-#ctor-PSU_OOP_CourseWork-ViewModels-Source-IOrders-'></a>
### #ctor(orders) `constructor`

##### Summary

ViewModel Заказов

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| orders | [PSU_OOP_CourseWork.ViewModels.Source.IOrders](#T-PSU_OOP_CourseWork-ViewModels-Source-IOrders 'PSU_OOP_CourseWork.ViewModels.Source.IOrders') | Модель заказов |

<a name='M-PSU_OOP_CourseWork-ViewModels-OrdersViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Конструктор для debug'а

##### Parameters

This constructor has no parameters.

<a name='P-PSU_OOP_CourseWork-ViewModels-OrdersViewModel-Rows'></a>
### Rows `property`

##### Summary

Строки для таблицы заказов

<a name='T-PSU_OOP_CourseWork-Views-ScottPlotDialog'></a>
## ScottPlotDialog `type`

##### Namespace

PSU_OOP_CourseWork.Views

##### Summary

Общее диалогоое окно для графиков на базе ScottPlot

<a name='M-PSU_OOP_CourseWork-Views-ScottPlotDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Конструктор с запуском инициализации

##### Parameters

This constructor has no parameters.

<a name='M-PSU_OOP_CourseWork-Views-ScottPlotDialog-#ctor-System-Action{ScottPlot-Plot}-'></a>
### #ctor(onPlotReady) `constructor`

##### Summary

Конструктор с подпиской на конец инициализации

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onPlotReady | [System.Action{ScottPlot.Plot}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{ScottPlot.Plot}') |  |

<a name='M-PSU_OOP_CourseWork-Views-ScottPlotDialog-InitializeComponent-System-Boolean,System-Boolean-'></a>
### InitializeComponent(loadXaml,attachDevTools) `method`

##### Summary

Wires up the controls and optionally loads XAML markup and attaches dev tools (if Avalonia.Diagnostics package is referenced).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loadXaml | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the XAML be loaded into the component. |
| attachDevTools | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the dev tools be attached. |

<a name='T-PSU_OOP_CourseWork-DB-SqlService'></a>
## SqlService `type`

##### Namespace

PSU_OOP_CourseWork.DB

##### Summary

Фасад работы с БД на SQL

<a name='M-PSU_OOP_CourseWork-DB-SqlService-#ctor'></a>
### #ctor() `constructor`

##### Summary

Инициализирует публичные источники данных и первчино создаёт или закгружает БД

##### Parameters

This constructor has no parameters.

<a name='P-PSU_OOP_CourseWork-DB-SqlService-Dishes'></a>
### Dishes `property`

##### Summary

Источник текущих данных о хранимых блюдах

<a name='P-PSU_OOP_CourseWork-DB-SqlService-Orders'></a>
### Orders `property`

##### Summary

Источник текущих данных о хранимых заказах

<a name='M-PSU_OOP_CourseWork-DB-SqlService-ChangeDishPrice-System-Int32,System-Decimal-'></a>
### ChangeDishPrice(id,priceRoubles) `method`

##### Summary

Меняет цену блюда

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id блюда |
| priceRoubles | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Новая цена блюда |

<a name='M-PSU_OOP_CourseWork-DB-SqlService-Load'></a>
### Load() `method`

##### Summary

Загружает данные БД из ранее выгруженного формата

##### Parameters

This method has no parameters.

<a name='M-PSU_OOP_CourseWork-DB-SqlService-PushOrder-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-OrderPosition}-'></a>
### PushOrder(positions) `method`

##### Summary

Добавляет новый заказ в БД и перезагружает источник заказов

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| positions | [System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.OrderPosition}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.OrderPosition}') | Позиции заказа |

<a name='M-PSU_OOP_CourseWork-DB-SqlService-RemoveDish-System-Int32-'></a>
### RemoveDish(id) `method`

##### Summary

Удаляет блюдо из меню по его Id, если оно не упомянуто в заказах

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id блюда |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Data.ConstraintException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.ConstraintException 'System.Data.ConstraintException') | Исключение бросается6 если блюдо нельзя удалить в связи с его использованием в заказах |

<a name='M-PSU_OOP_CourseWork-DB-SqlService-RemoveOrder-System-Int32-'></a>
### RemoveOrder(id) `method`

##### Summary

Удаление заказа

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id удаляемого заказа |

<a name='M-PSU_OOP_CourseWork-DB-SqlService-Save'></a>
### Save() `method`

##### Summary

Выгружает данные БД в текстовом, ~читабельном формате

##### Parameters

This method has no parameters.

<a name='T-PSU_OOP_CourseWork-Util-StringExtension'></a>
## StringExtension `type`

##### Namespace

PSU_OOP_CourseWork.Util

##### Summary

Расширяющий класс для строк

<a name='M-PSU_OOP_CourseWork-Util-StringExtension-CoalesceEmpty-System-String-'></a>
### CoalesceEmpty(s) `method`

##### Summary

Возвращает пустую строку, если оригинальная строка == null

##### Returns

Оригинальную строку или пустую строку, если оригинал == null

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nullable строка |

<a name='T-PSU_OOP_CourseWork-Models-Stubs-Stubs'></a>
## Stubs `type`

##### Namespace

PSU_OOP_CourseWork.Models.Stubs

##### Summary

Фейковый класс для всевдоработы с БД во время отладки других систем

<a name='T-PSU_OOP_CourseWork-Util-TimeExtension'></a>
## TimeExtension `type`

##### Namespace

PSU_OOP_CourseWork.Util

##### Summary

Расширяющий класс для работы с классами времени

<a name='M-PSU_OOP_CourseWork-Util-TimeExtension-AtLeast-System-DateTime,System-DateTime-'></a>
### AtLeast(dateTime,minConstraint) `method`

##### Summary

Возвращает указанную дату, если она больше или равна заданному минимальному значению; 
в противном случае возвращает минимальное значение.

##### Returns

Если `dateTime` больше или равен `minConstraint`, 
возвращает `dateTime`; в противном случае возвращает `minConstraint`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Дата, которую необходимо проверить. |
| minConstraint | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Минимально допустимая дата. |

<a name='M-PSU_OOP_CourseWork-Util-TimeExtension-Hours-System-Int32-'></a>
### Hours(hours) `method`

##### Summary

Фабричный метод создания времени из числа (kotlin-like)

##### Returns

Время

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hours | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Часы |

<a name='M-PSU_OOP_CourseWork-Util-TimeExtension-OnlyDate-System-DateTime-'></a>
### OnlyDate(dateTime) `method`

##### Summary

Обрезает DateTime до только даты (DateOnly)

##### Returns

TimeOnly -- только дату

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Дата и время |

<a name='M-PSU_OOP_CourseWork-Util-TimeExtension-OnlyTime-System-DateTime-'></a>
### OnlyTime(dateTime) `method`

##### Summary

Обрезает DateTime до только времени (TimeOnly)

##### Returns

TimeOnly -- только время

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Дата и время |

<a name='T-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection'></a>
## TransformedReadOnlyObservableCollection `type`

##### Namespace

PSU_OOP_CourseWork.Util

##### Summary

Расширяющие методы для удобной трансформации обозреваемых коллекций

<a name='M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection-TransformedToReadonly``1-System-Collections-ObjectModel-ObservableCollection{``0}-'></a>
### TransformedToReadonly\`\`1(source) `method`

##### Summary

Converts an [ObservableCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ObservableCollection`1 'System.Collections.ObjectModel.ObservableCollection`1') into a read-only observable collection without transformation.

##### Returns

A new read-only observable collection containing the same elements as the source.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.ObjectModel.ObservableCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ObservableCollection 'System.Collections.ObjectModel.ObservableCollection{``0}') | The source collection to convert. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the source collection. |

<a name='M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection-Transformed``2-System-Collections-ObjectModel-ReadOnlyObservableCollection{``0},System-Func{``0,``1}-'></a>
### Transformed\`\`2(source,transformer) `method`

##### Summary

Transforms the elements of a [ReadOnlyObservableCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyObservableCollection`1 'System.Collections.ObjectModel.ReadOnlyObservableCollection`1') into a new [ReadOnlyObservableCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyObservableCollection`1 'System.Collections.ObjectModel.ReadOnlyObservableCollection`1').

##### Returns

A new transformed read-only observable collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.ObjectModel.ReadOnlyObservableCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyObservableCollection 'System.Collections.ObjectModel.ReadOnlyObservableCollection{``0}') | The source collection to transform. |
| transformer | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The function used to transform each element from type `T` to type `R`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the source collection. |
| R | The type of elements in the transformed collection. |

<a name='M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection-Transformed``2-System-Collections-ObjectModel-ObservableCollection{``0},System-Func{``0,``1}-'></a>
### Transformed\`\`2(source,transformer) `method`

##### Summary

Transforms the elements of an [ObservableCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ObservableCollection`1 'System.Collections.ObjectModel.ObservableCollection`1') into a new [ReadOnlyObservableCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyObservableCollection`1 'System.Collections.ObjectModel.ReadOnlyObservableCollection`1').

##### Returns

A new transformed read-only observable collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.ObjectModel.ObservableCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ObservableCollection 'System.Collections.ObjectModel.ObservableCollection{``0}') | The source collection to transform. |
| transformer | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The function used to transform each element from type `T` to type `R`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the source collection. |
| R | The type of elements in the transformed collection. |

<a name='T-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2'></a>
## TransformedReadOnlyObservableCollection\`2 `type`

##### Namespace

PSU_OOP_CourseWork.Util

##### Summary

Представляет коллекцию, которая является только для чтения и содержит преобразованные элементы из исходной коллекции.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип элементов в исходной коллекции. |
| R | Тип элементов в преобразованной коллекции. |

<a name='M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2-#ctor-System-Collections-ObjectModel-ReadOnlyObservableCollection{`0},System-Func{`0,`1}-'></a>
### #ctor(source,transformer) `constructor`

##### Summary

Конструктор из изменяемой коллекции [ObservableCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ObservableCollection`1 'System.Collections.ObjectModel.ObservableCollection`1')
в [TransformedReadOnlyObservableCollection\`2](#T-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection`2').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.ObjectModel.ReadOnlyObservableCollection{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyObservableCollection 'System.Collections.ObjectModel.ReadOnlyObservableCollection{`0}') | Коллекция для трасформации. |
| transformer | [System.Func{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1}') | Функция преобразования `T` в `R`. |

<a name='M-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2-#ctor-System-Collections-ObjectModel-ObservableCollection{`0},System-Func{`0,`1}-'></a>
### #ctor(source,transformer) `constructor`

##### Summary

Конструктор из неизменяемой коллекции [ObservableCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ObservableCollection`1 'System.Collections.ObjectModel.ObservableCollection`1')
в [TransformedReadOnlyObservableCollection\`2](#T-PSU_OOP_CourseWork-Util-TransformedReadOnlyObservableCollection`2 'PSU_OOP_CourseWork.Util.TransformedReadOnlyObservableCollection`2').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.ObjectModel.ObservableCollection{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ObservableCollection 'System.Collections.ObjectModel.ObservableCollection{`0}') | Коллекция для трасформации. |
| transformer | [System.Func{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1}') | Функция преобразования `T` в `R`. |

<a name='T-PSU_OOP_CourseWork-ViewModelsModels-Util'></a>
## Util `type`

##### Namespace

PSU_OOP_CourseWork.ViewModelsModels

##### Summary

Утилиты

<a name='M-PSU_OOP_CourseWork-ViewModelsModels-Util-FindById-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-Dish},System-Int32-'></a>
### FindById(source,id) `method`

##### Summary

Поиск блюда по id

##### Returns

Искомое блюдо

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.Dish}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.Dish}') | Блюда |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор искомого |

<a name='M-PSU_OOP_CourseWork-ViewModelsModels-Util-FindById-System-Collections-Generic-IEnumerable{PSU_OOP_CourseWork-Models-Datums-Order},System-Int32-'></a>
### FindById(source,id) `method`

##### Summary

Поиск заказа по id

##### Returns

Искомый заказ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.Order}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{PSU_OOP_CourseWork.Models.Datums.Order}') | Заказы |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор заказа |

<a name='T-PSU_OOP_CourseWork-ViewLocator'></a>
## ViewLocator `type`

##### Namespace

PSU_OOP_CourseWork

<a name='M-PSU_OOP_CourseWork-ViewLocator-Match-System-Object-'></a>
### Match() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-PSU_OOP_CourseWork-ViewModels-ViewModelBase'></a>
## ViewModelBase `type`

##### Namespace

PSU_OOP_CourseWork.ViewModels

##### Summary

Базовый класс для ViewModel'ей
