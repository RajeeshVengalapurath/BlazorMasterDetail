# BlazorMasterDetail
# EntityFramework: FirstOrDefault
# INotifyPropertyChanged
# Detail: Rate * Quantity = Total
#         event PropertyChangedEventHandler PropertyChanged
#         PropertyChanged?.Invoke
#         GreaterThanDecimal (Custom Validation Attribute)
# Master: PropertyChangedEventHandler DetailPropertyChanged
#         AddNewDetailRow
#         detail.PropertyChanged += Detail_PropertyChanged
#         Total = _net - Discount;
#         public List<KeyValuePair<string, int>> Products
# Index.razor.cs: Master/Detail Binding
#                 Product List to KeyValuePair Conversion for Lookup
#                 Master.DetailPropertyChanged += Master_DetailPropertyChanged;
#                 Detect Detail productId property changeto update detail rate
# Index.razor: <DataAnnotationsValidator />, 
#              <ValidationSummary />
#              <InputNumber @bind-Value="Master.xxx" /> 
#              <ValidationMessage For="() => Master.xxx" />
#              <InputSelect @bind-Value="Master.xxx">
#              <InputCheckbox @bind-Value="Master.xxx"/>
#              <InputText @bind-Value="Master.xxx">
#              Split Binding to -> ValueExpression, Value & ValueChanged to handle ValueChanged event
# CSS: Grid, grid-template-rows, 1fr, flex, overflow-y: scroll, grid-gap, flex-direction, input:focus
