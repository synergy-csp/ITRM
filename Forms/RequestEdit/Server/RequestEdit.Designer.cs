using System;
using System.Collections.Generic;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Bimser.CSP.FormControls.Base;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.RuleManager;
using Bimser.CSP.FormControls.Enums;
using Bimser.Framework.Monitoring;
using Newtonsoft.Json;
using ITRM.Entities;

namespace ITRM.Forms {

    public partial class RequestEdit : Form<E_ITRM_RequestEditEntity> {

        // properties
        RadioList OpenType { get; set; }
Lookup RequestorDepartment { get; set; }
ComboBox Priority { get; set; }
ComboBox RequestType { get; set; }
RelatedDocuments RelatedDocuments { get; set; }
DocumentMetadata RequestNo { get; set; }
Lookup RequestorLook { get; set; }
UserMetadata Requestor { get; set; }
ComboBox RequestReason { get; set; }
Divider Divider1 { get; set; }
HTMLTextBox Images { get; set; }
TextArea Description { get; set; }
DateTimePicker RequestDate { get; set; }
Label Label1 { get; set; }
TextArea DeveloperDescription { get; set; }
TextArea ReviewReason { get; set; }


        // constructor
        public RequestEdit(FormHttpParameters httpParameters, ITelemetryCollectorHolder telemetryCollectorHolder = null)
 : base(httpParameters, telemetryCollectorHolder)
        {

        }

        // initialize members
        public override void InitMembers ()
        {
            
BaseComponent default_column6Component = new BaseComponent {
Id = "Column6",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Description",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column6Component);

BaseComponent default_column7Component = new BaseComponent {
Id = "Column7",
Type = "Column",
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Divider1",
"Label1",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column7Component);

BaseComponent default_column8Component = new BaseComponent {
Id = "Column8",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RelatedDocuments",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);

BaseComponent default_column9Component = new BaseComponent {
Id = "Column9",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Images",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);

OpenType = new RadioList {
ControlId = "4a5e58e4-a52a-a3c4-c250-1a5a75d36c25",
Name = "OpenType",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "OpenType_OnValueChanged",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Açılış Tipi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.OPENTYPE",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
Direction = Direction.Horizontal,
ButtonType = RadioListButtonType.Radio,
ShowSearch = false,
};

Controls.Add(OpenType);
OpenType.Items = new ListItemCollection();

OpenType.Items.Add(new ListItem {
Value = "1",
Key = "1",
Icon = @"",
Selected = true,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kendi adıma" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

OpenType.Items.Add(new ListItem {
Value = "2",
Key = "2",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Başkası adına" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_opentypeComponent = new BaseComponent {
Id = "OpenType",
Type = "RadioList",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = OpenType,
ViewProperties = "",
};

AddToViewItems("default", default_opentypeComponent);

RequestorDepartment = new Lookup {
ControlId = "0e8ed5dd-5c40-d9df-273e-eeeb356b6e9c",
Name = "RequestorDepartment",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnLoad",
MethodName = "RequestorDepartment_OnLoad",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = false,
DefaultEnabled = false,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "lookupButton",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Departman" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.REQUESTORDEPARTMENT",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = null,
},
GridOptions = new LookupGridOptions {
Columns = new DataGridColumnCollection {
},
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
HeaderFilterEnabled = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
Selection = new LookupSelectionOptions {
Mode = DataGridSelectionMode.Single,
},
},
AllowClear = false,
SizeType = SizeType.Middle,
ValueType = PrimitiveType.String,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Text = ""
};

Controls.Add(RequestorDepartment);

BaseComponent default_requestordepartmentComponent = new BaseComponent {
Id = "RequestorDepartment",
Type = "Lookup",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestorDepartment,
ViewProperties = "",
};

AddToViewItems("default", default_requestordepartmentComponent);

Priority = new ComboBox {
ControlId = "36afba35-de24-add6-e4c3-fc18ffd99d8a",
Name = "Priority",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Öncelik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.PRIORITY",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "Priorities",
ValueMember = "DOCUMENTID",
DisplayMember = new List<string>{
"PRIORITY",
},
DisplayFormat = "{{ PRIORITY }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.REST,
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = SizeType.Middle,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
};

Controls.Add(Priority);
Priority.Items = new ListItemCollection();

BaseComponent default_priorityComponent = new BaseComponent {
Id = "Priority",
Type = "ComboBox",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Priority,
ViewProperties = "",
};

AddToViewItems("default", default_priorityComponent);

RequestType = new ComboBox {
ControlId = "fe7067ba-1cc7-8c86-7b5d-093384a04dc6",
Name = "RequestType",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep Tipi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.REQUESTTYPE",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "RequestTypes",
ValueMember = "DOCUMENTID",
DisplayMember = new List<string>{
"REQUESTTYPE",
},
DisplayFormat = "{{ REQUESTTYPE }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.REST,
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = SizeType.Middle,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
};

Controls.Add(RequestType);
RequestType.Items = new ListItemCollection();

BaseComponent default_requesttypeComponent = new BaseComponent {
Id = "RequestType",
Type = "ComboBox",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestType,
ViewProperties = "",
};

AddToViewItems("default", default_requesttypeComponent);

BaseComponent default_section1Component = new BaseComponent {
Id = "Section1",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column1",
"Column2",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section1Component);

BaseComponent default_section2Component = new BaseComponent {
Id = "Section2",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column3",
"Column4",
"Column5",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section2Component);

RelatedDocuments = new RelatedDocuments {
ControlId = "857e4cfc-a6a5-dc88-a848-6717b039b57d",
Name = "RelatedDocuments",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İlişkili Dokümanlar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "RD.RelatedDocuments",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
Categories = new List<RelatedDocumentCategory> {
new RelatedDocumentCategory {
Id = 0,
CategoryId = "31e31853-daad-72b6-5dce-b56df4e2b8e7",
Name = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
Description = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
MinFilesCount = 0,
MaxFilesCount = null,
MaxFileSize = null,
AllowedFileExtensions = new List<string> {
},
Enabled = true,
Path = "Projeler/ITRM/asset",
TargetId = "197635"
},
},
Files = new List<RelatedDocumentFile> {
},
AddingMode = RelatedDocumentsAddingMode.All,
ViewType = RelatedDocumentsViewType.Card,
AddNewEnabled = true,
DeleteEnabled = true,
Viewable = true,
CreateEnabled = false,
Path = "Projeler/ITRM/asset",
ShowCategoryDescription = false,
ShowFileDescription = false,
FileDescriptionIsRequired = false,
ShowContentForImageFiles = false,
ShowCreateDate = true,
ShowCreator = false,
ShowFileExtension = true,
ShowPath = true,
TargetId = "197635",
};

Controls.Add(RelatedDocuments);

BaseComponent default_relateddocumentsComponent = new BaseComponent {
Id = "RelatedDocuments",
Type = "RelatedDocuments",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RelatedDocuments,
ViewProperties = "",
};

AddToViewItems("default", default_relateddocumentsComponent);

BaseComponent default_section3Component = new BaseComponent {
Id = "Section3",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column6",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section3Component);

BaseComponent default_section4Component = new BaseComponent {
Id = "Section4",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column7",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section4Component);

RequestNo = new DocumentMetadata {
ControlId = "1379fa9a-9483-1d1e-7279-45eb1d69c9f7",
Name = "RequestNo",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep No" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "UNIQUEID",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = DocumentMetadataType.Id,
DateFormat = "",
SizeType = SizeType.Middle,
PullNumberOnStart = true,
PullNewNumber = false,
};

Controls.Add(RequestNo);

BaseComponent default_requestnoComponent = new BaseComponent {
Id = "RequestNo",
Type = "DocumentMetadata",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestNo,
ViewProperties = "",
};

AddToViewItems("default", default_requestnoComponent);

BaseComponent default_section5Component = new BaseComponent {
Id = "Section5",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column8",
"Column9",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section5Component);

RequestorLook = new Lookup {
ControlId = "7670220e-5955-72c1-957f-4974f567f872",
Name = "RequestorLook",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep Eden" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.REQUESTORLOOK",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "GetUsers",
ValueMember = "id",
DisplayMember = new List<string>{
"firstname",
"lastname",
},
DisplayFormat = "{{ firstname }} {{ lastname }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
new DataSourceParameter {
Name = "department",
IsRequired = true,
Length = 0,
ValueType = ParameterValueType.String,
ValueModifier = ValueModifierType.FieldSelection,
Field = "RequestEdit.session.User.Department.Id",
Value = "1",
Children = new List<DataSourceParameter>{
},
},
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.REST,
},
GridOptions = new LookupGridOptions {
Columns = new DataGridColumnCollection {
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "id"
},
DbType = new ColumnDbType() {
ColumnName = "id",
Type = "decimal"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "id" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.NumberBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "id",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = true,
IsGeneratedColumn = true,
Visible = false,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.firstname",
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "firstname",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Adı" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "firstname",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "50%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.lastname",
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "lastname",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Soyadı" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "lastname",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "50%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
},
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
HeaderFilterEnabled = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
Selection = new LookupSelectionOptions {
Mode = DataGridSelectionMode.Single,
},
},
AllowClear = false,
SizeType = SizeType.Middle,
ValueType = PrimitiveType.String,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Text = ""
};

Controls.Add(RequestorLook);

BaseComponent default_requestorlookComponent = new BaseComponent {
Id = "RequestorLook",
Type = "Lookup",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestorLook,
ViewProperties = "",
};

AddToViewItems("default", default_requestorlookComponent);

Requestor = new UserMetadata {
ControlId = "27ce93c6-7e1d-dcb6-b192-c3d0ec95b846",
Name = "Requestor",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep Eden" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "REQUESTOR",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = UserMetadataType.NameAndSurname,
CustomMetadataName = "",
SizeType = SizeType.Middle,
PropertyType = UserMetadataOptionTypes.Text,
LocationDataType = LocationDataType.Coordinates,
};

Controls.Add(Requestor);

BaseComponent default_requestorComponent = new BaseComponent {
Id = "Requestor",
Type = "UserMetadata",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Requestor,
ViewProperties = "",
};

AddToViewItems("default", default_requestorComponent);

RequestReason = new ComboBox {
ControlId = "5d5e88f2-87f8-dc4e-48eb-09241b6df3a8",
Name = "RequestReason",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep Nedeni" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.REQUESTREASON",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "RequestReason",
ValueMember = "DOCUMENTID",
DisplayMember = new List<string>{
"REQUESTREASON",
},
DisplayFormat = "{{ REQUESTREASON }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
new DataSourceParameter {
Name = "requestTypeId",
IsRequired = true,
Length = 0,
ValueType = ParameterValueType.String,
ValueModifier = ValueModifierType.FieldSelection,
Field = "RequestType.value",
Value = "196850",
Children = new List<DataSourceParameter>{
},
},
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.REST,
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = SizeType.Middle,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
};

Controls.Add(RequestReason);
RequestReason.Items = new ListItemCollection();

BaseComponent default_requestreasonComponent = new BaseComponent {
Id = "RequestReason",
Type = "ComboBox",
ParentId = "Column4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestReason,
ViewProperties = "",
};

AddToViewItems("default", default_requestreasonComponent);

Divider1 = new Divider {
ControlId = "ebc3a0d1-5e59-d3c3-3f96-9914f9ed6d30",
Name = "Divider1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "rgb(0, 0, 0)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
};

Controls.Add(Divider1);

BaseComponent default_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("default", default_divider1Component);

Images = new HTMLTextBox {
ControlId = "c3520289-14d9-7136-8929-d6bd8cbc1222",
Name = "Images",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görseller" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.IMAGES",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = "",
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Height = null,
CharCounterMax = null,
ToolbarBottom = false,
ToolbarType = "rich",
};

Controls.Add(Images);

BaseComponent default_imagesComponent = new BaseComponent {
Id = "Images",
Type = "HTMLTextBox",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Images,
ViewProperties = "",
};

AddToViewItems("default", default_imagesComponent);

ClientVisible = true;
ProjectName = "ITRM";
ProjectId = "9e58b961-38b8-4f2b-99dc-d3bc2497c7ed";
EntityPath = "";
ActiveView = "default";
Version = 10;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "RequestEdit" },
{ "en-US", "RequestEdit" },
};
Name = "RequestEdit";
FormId = "ca3d5c8e-02d6-43c6-8dda-186e1fc1dfdd";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
new EventItem {
Name = "OnLoad",
MethodName = "RequestEdit_OnLoad",
Async = null
},
};
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnLoad",
MethodName = "RequestEdit_OnLoad",
Async = null
},
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "ITRM";
IdentityFormatId = 214;
PrintingEnabled = false;
PrintView = "default";
CopyPasteEnabled = false;
VersioningEnabled = false;
CanSaveAsDraft = false;
PanelSize = 2;
Style = new Style {
Padding = "10px 20px 10px 20px",
BackgroundColor = "rgba(255, 255, 255, 0)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
};
PublicFields = new List<FormPublicField> {
};
ToolbarButtons = new List<ToolbarButton> {
new ToolbarButton {
Key = "toolbarSaveButton",
Name = "Kaydet",
Icon = "save",
Enabled = true,
DefaultEnabled = true,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Kaydet" },
{ "en-US", "Save" },
},
View = "",
IsServerPrint = false,
},
new ToolbarButton {
Key = "toolbarSaveAsButton",
Name = "Farklı Kaydet",
Icon = "save-as",
Enabled = false,
DefaultEnabled = false,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Farklı Kaydet" },
{ "en-US", "Save As" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_Statement_default_RequestType",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_RequestType",
Name = "Talep Tipi",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Talep Tipi: Gerekli alan"
},
{
"en-US",
"Talep Tipi: Required field"
},
{
"ru-RU",
"Talep Tipi: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"RequestType",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_RequestType",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_RequestType_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestType",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_RequestType",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestEdit",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_RequestReason",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_RequestReason",
Name = "Talep Nedeni",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Talep Nedeni: Gerekli alan"
},
{
"en-US",
"Talep Nedeni: Required field"
},
{
"ru-RU",
"Talep Nedeni: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"RequestReason",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_RequestReason",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_RequestReason_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestReason",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_RequestReason",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestEdit",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_Priority",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_Priority",
Name = "Öncelik",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Öncelik: Gerekli alan"
},
{
"en-US",
"Öncelik: Required field"
},
{
"ru-RU",
"Öncelik: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Priority",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_Priority",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_Priority_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Priority",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_Priority",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestEdit",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_Description",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_Description",
Name = "Açıklama",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Açıklama: Gerekli alan"
},
{
"en-US",
"Açıklama: Required field"
},
{
"ru-RU",
"Açıklama: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Description",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_Description",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_Description_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Description",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_Description",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestEdit",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_RequestorLook",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_RequestorLook",
Name = "Talep Eden",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Talep Eden: Gerekli alan"
},
{
"en-US",
"Talep Eden: Required field"
},
{
"ru-RU",
"Talep Eden: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"RequestorLook",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_RequestorLook",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_RequestorLook_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestorLook",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_RequestorLook",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "RequestEdit",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
new ValueEntryCondition {
Id = "749e4052-9d57-e3ff-d7cc-007c0e829e88",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "OpenType",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "2"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_RequestType",
Name = "Talep Tipi",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Talep Tipi: Gerekli alan"
},
{
"en-US",
"Talep Tipi: Required field"
},
{
"ru-RU",
"Talep Tipi: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"RequestType",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_RequestReason",
Name = "Talep Nedeni",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Talep Nedeni: Gerekli alan"
},
{
"en-US",
"Talep Nedeni: Required field"
},
{
"ru-RU",
"Talep Nedeni: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"RequestReason",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_Priority",
Name = "Öncelik",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Öncelik: Gerekli alan"
},
{
"en-US",
"Öncelik: Required field"
},
{
"ru-RU",
"Öncelik: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Priority",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_Description",
Name = "Açıklama",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Açıklama: Gerekli alan"
},
{
"en-US",
"Açıklama: Required field"
},
{
"ru-RU",
"Açıklama: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Description",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_RequestorLook",
Name = "Talep Eden",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Talep Eden: Gerekli alan"
},
{
"en-US",
"Talep Eden: Required field"
},
{
"ru-RU",
"Talep Eden: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"RequestorLook",
},
},
},
TriggerEvents = new List<string> {
"RequestEdit.client.OnBeforeSave",
"RequestEdit.server.OnBeforeSave",
"RequestEdit.client.OnToolbarButtonClicked",
"RequestEdit.server.OnToolbarButtonClicked",
}
}
},
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yeni Talep" },{ "en-US", "RequestEdit" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
};

Controls.Add(this);

BaseComponent default_requesteditComponent = new BaseComponent {
Id = "RequestEdit",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section1",
"Section2",
"Section3",
"Section4",
"Section5",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_requesteditComponent);

BaseComponent default_column1Component = new BaseComponent {
Id = "Column1",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"OpenType",
"RequestNo",
"RequestDate",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);

BaseComponent default_column2Component = new BaseComponent {
Id = "Column2",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Requestor",
"RequestorLook",
"RequestorDepartment",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column2Component);

Description = new TextArea {
ControlId = "375c29e0-2080-0768-d650-2b8310bd0fcc",
Name = "Description",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Açıklama" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.DESCRIPTION",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 5000,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = true,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(Description);

BaseComponent default_descriptionComponent = new BaseComponent {
Id = "Description",
Type = "TextArea",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Description,
ViewProperties = "",
};

AddToViewItems("default", default_descriptionComponent);

RequestDate = new DateTimePicker {
ControlId = "fbc47f60-de5b-8648-11f4-5268db26c829",
Name = "RequestDate",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep Tarihi/Saat" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "REQUESTDATE",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "YYYY-MM-DD HH:mm",
SetTodayAsDefault = true,
ShowTime = true,
ShowToday = false,
SizeType = SizeType.Middle,
AllowClear = false,
DisableBefore = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
DisableAfter = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
};

Controls.Add(RequestDate);

BaseComponent default_requestdateComponent = new BaseComponent {
Id = "RequestDate",
Type = "DateTimePicker",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestDate,
ViewProperties = "",
};

AddToViewItems("default", default_requestdateComponent);

BaseComponent default_column3Component = new BaseComponent {
Id = "Column3",
Type = "Column",
ParentId = "Section2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RequestType",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);

Label1 = new Label {
ControlId = "520350cc-1be6-c570-c906-0901ac3fdafd",
Name = "Label1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ekler" },{ "en-US", "Label1" },{ "ru-RU", "Label1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
};

Controls.Add(Label1);

BaseComponent default_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Label1,
ViewProperties = "",
};

AddToViewItems("default", default_label1Component);

BaseComponent default_column4Component = new BaseComponent {
Id = "Column4",
Type = "Column",
ParentId = "Section2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RequestReason",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);

BaseComponent default_column5Component = new BaseComponent {
Id = "Column5",
Type = "Column",
ParentId = "Section2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Priority",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column5Component);

BaseComponent developeruser_opentypeComponent = new BaseComponent {
Id = "OpenType",
Type = "RadioList",
ParentId = "Column19",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = OpenType,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_opentypeComponent);

BaseComponent developeruser_requestordepartmentComponent = new BaseComponent {
Id = "RequestorDepartment",
Type = "Lookup",
ParentId = "Column20",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestorDepartment,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requestordepartmentComponent);

BaseComponent developeruser_priorityComponent = new BaseComponent {
Id = "Priority",
Type = "ComboBox",
ParentId = "Column23",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Priority,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_priorityComponent);

BaseComponent developeruser_requesttypeComponent = new BaseComponent {
Id = "RequestType",
Type = "ComboBox",
ParentId = "Column21",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestType,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requesttypeComponent);

BaseComponent developeruser_relateddocumentsComponent = new BaseComponent {
Id = "RelatedDocuments",
Type = "RelatedDocuments",
ParentId = "Column12",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RelatedDocuments,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_relateddocumentsComponent);

BaseComponent developeruser_requestnoComponent = new BaseComponent {
Id = "RequestNo",
Type = "DocumentMetadata",
ParentId = "Column19",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestNo,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requestnoComponent);

BaseComponent developeruser_requestorlookComponent = new BaseComponent {
Id = "RequestorLook",
Type = "Lookup",
ParentId = "Column20",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestorLook,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requestorlookComponent);

BaseComponent developeruser_requestorComponent = new BaseComponent {
Id = "Requestor",
Type = "UserMetadata",
ParentId = "Column20",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Requestor,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requestorComponent);

DeveloperDescription = new TextArea {
ControlId = "b36074fe-71cc-eeb1-5c4c-f93d42ca14de",
Name = "DeveloperDescription",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İşi Yapan Kullanıcı Açıklaması" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.DEVELOPERDESCRIPTION",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 5000,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = true,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(DeveloperDescription);

BaseComponent developeruser_developerdescriptionComponent = new BaseComponent {
Id = "DeveloperDescription",
Type = "TextArea",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DeveloperDescription,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_developerdescriptionComponent);

BaseComponent developeruser_requestreasonComponent = new BaseComponent {
Id = "RequestReason",
Type = "ComboBox",
ParentId = "Column22",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestReason,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requestreasonComponent);

BaseComponent developeruser_column20Component = new BaseComponent {
Id = "Column20",
Type = "Column",
ParentId = "Column14",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Requestor",
"RequestorLook",
"RequestorDepartment",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column20Component);

BaseComponent developeruser_column10Component = new BaseComponent {
Id = "Column10",
Type = "Column",
ParentId = "Column16",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Description",
"DeveloperDescription",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column10Component);

BaseComponent developeruser_column21Component = new BaseComponent {
Id = "Column21",
Type = "Column",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RequestType",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column21Component);

BaseComponent developeruser_column11Component = new BaseComponent {
Id = "Column11",
Type = "Column",
ParentId = "Column17",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Divider1",
"Label1",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column11Component);

BaseComponent developeruser_column22Component = new BaseComponent {
Id = "Column22",
Type = "Column",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RequestReason",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column22Component);

BaseComponent developeruser_column12Component = new BaseComponent {
Id = "Column12",
Type = "Column",
ParentId = "Column18",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RelatedDocuments",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column12Component);

BaseComponent developeruser_column23Component = new BaseComponent {
Id = "Column23",
Type = "Column",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Priority",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column23Component);

BaseComponent developeruser_column13Component = new BaseComponent {
Id = "Column13",
Type = "Column",
ParentId = "Column18",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Images",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column13Component);

BaseComponent developeruser_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_divider1Component);

BaseComponent developeruser_imagesComponent = new BaseComponent {
Id = "Images",
Type = "HTMLTextBox",
ParentId = "Column13",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Images,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_imagesComponent);

BaseComponent developeruser_column14Component = new BaseComponent {
Id = "Column14",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column19",
"Column20",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column14Component);

BaseComponent developeruser_requesteditComponent = new BaseComponent {
Id = "RequestEdit",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column14",
"Column15",
"Column16",
"Column17",
"Column18",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requesteditComponent);

BaseComponent developeruser_column15Component = new BaseComponent {
Id = "Column15",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column21",
"Column22",
"Column23",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column15Component);

BaseComponent developeruser_column16Component = new BaseComponent {
Id = "Column16",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column10",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column16Component);

BaseComponent developeruser_column17Component = new BaseComponent {
Id = "Column17",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column11",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column17Component);

BaseComponent developeruser_descriptionComponent = new BaseComponent {
Id = "Description",
Type = "TextArea",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Description,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_descriptionComponent);

BaseComponent developeruser_column18Component = new BaseComponent {
Id = "Column18",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column12",
"Column13",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column18Component);

BaseComponent developeruser_requestdateComponent = new BaseComponent {
Id = "RequestDate",
Type = "DateTimePicker",
ParentId = "Column19",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestDate,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_requestdateComponent);

BaseComponent developeruser_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Label1,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_label1Component);

BaseComponent developeruser_column19Component = new BaseComponent {
Id = "Column19",
Type = "Column",
ParentId = "Column14",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"OpenType",
"RequestNo",
"RequestDate",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("developerUser", developeruser_column19Component);

BaseComponent revieweruser_opentypeComponent = new BaseComponent {
Id = "OpenType",
Type = "RadioList",
ParentId = "Column37",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = OpenType,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_opentypeComponent);

BaseComponent revieweruser_requestordepartmentComponent = new BaseComponent {
Id = "RequestorDepartment",
Type = "Lookup",
ParentId = "Column24",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestorDepartment,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requestordepartmentComponent);

BaseComponent revieweruser_priorityComponent = new BaseComponent {
Id = "Priority",
Type = "ComboBox",
ParentId = "Column30",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Priority,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_priorityComponent);

BaseComponent revieweruser_requesttypeComponent = new BaseComponent {
Id = "RequestType",
Type = "ComboBox",
ParentId = "Column26",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestType,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requesttypeComponent);

BaseComponent revieweruser_relateddocumentsComponent = new BaseComponent {
Id = "RelatedDocuments",
Type = "RelatedDocuments",
ParentId = "Column29",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RelatedDocuments,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_relateddocumentsComponent);

BaseComponent revieweruser_requestnoComponent = new BaseComponent {
Id = "RequestNo",
Type = "DocumentMetadata",
ParentId = "Column37",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestNo,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requestnoComponent);

BaseComponent revieweruser_requestorlookComponent = new BaseComponent {
Id = "RequestorLook",
Type = "Lookup",
ParentId = "Column24",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestorLook,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requestorlookComponent);

BaseComponent revieweruser_requestorComponent = new BaseComponent {
Id = "Requestor",
Type = "UserMetadata",
ParentId = "Column24",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Requestor,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requestorComponent);

BaseComponent revieweruser_developerdescriptionComponent = new BaseComponent {
Id = "DeveloperDescription",
Type = "TextArea",
ParentId = "Column25",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DeveloperDescription,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_developerdescriptionComponent);

BaseComponent revieweruser_column30Component = new BaseComponent {
Id = "Column30",
Type = "Column",
ParentId = "Column33",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Priority",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column30Component);

BaseComponent revieweruser_requestreasonComponent = new BaseComponent {
Id = "RequestReason",
Type = "ComboBox",
ParentId = "Column28",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestReason,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requestreasonComponent);

BaseComponent revieweruser_column31Component = new BaseComponent {
Id = "Column31",
Type = "Column",
ParentId = "Column36",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Images",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column31Component);

BaseComponent revieweruser_column32Component = new BaseComponent {
Id = "Column32",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column37",
"Column24",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column32Component);

BaseComponent revieweruser_column33Component = new BaseComponent {
Id = "Column33",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column26",
"Column28",
"Column30",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column33Component);

BaseComponent revieweruser_column34Component = new BaseComponent {
Id = "Column34",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column25",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column34Component);

BaseComponent revieweruser_column24Component = new BaseComponent {
Id = "Column24",
Type = "Column",
ParentId = "Column32",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Requestor",
"RequestorLook",
"RequestorDepartment",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column24Component);

BaseComponent revieweruser_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column27",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_divider1Component);

BaseComponent revieweruser_column35Component = new BaseComponent {
Id = "Column35",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column27",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column35Component);

BaseComponent revieweruser_imagesComponent = new BaseComponent {
Id = "Images",
Type = "HTMLTextBox",
ParentId = "Column31",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Images,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_imagesComponent);

BaseComponent revieweruser_column25Component = new BaseComponent {
Id = "Column25",
Type = "Column",
ParentId = "Column34",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Description",
"DeveloperDescription",
"ReviewReason",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column25Component);

BaseComponent revieweruser_column36Component = new BaseComponent {
Id = "Column36",
Type = "Section",
ParentId = "RequestEdit",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column29",
"Column31",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column36Component);

BaseComponent revieweruser_requesteditComponent = new BaseComponent {
Id = "RequestEdit",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column32",
"Column33",
"Column34",
"Column35",
"Column36",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requesteditComponent);

BaseComponent revieweruser_column26Component = new BaseComponent {
Id = "Column26",
Type = "Column",
ParentId = "Column33",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RequestType",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column26Component);

BaseComponent revieweruser_column37Component = new BaseComponent {
Id = "Column37",
Type = "Column",
ParentId = "Column32",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"OpenType",
"RequestNo",
"RequestDate",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column37Component);

BaseComponent revieweruser_column27Component = new BaseComponent {
Id = "Column27",
Type = "Column",
ParentId = "Column35",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Divider1",
"Label1",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column27Component);

BaseComponent revieweruser_column28Component = new BaseComponent {
Id = "Column28",
Type = "Column",
ParentId = "Column33",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RequestReason",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column28Component);

BaseComponent revieweruser_descriptionComponent = new BaseComponent {
Id = "Description",
Type = "TextArea",
ParentId = "Column25",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Description,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_descriptionComponent);

ReviewReason = new TextArea {
ControlId = "d69932bf-517d-4369-cebc-7692a9b6a26c",
Name = "ReviewReason",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görüş Nedeni" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.REVIEWREASON",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 5000,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = true,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(ReviewReason);

BaseComponent revieweruser_reviewreasonComponent = new BaseComponent {
Id = "ReviewReason",
Type = "TextArea",
ParentId = "Column25",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = ReviewReason,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_reviewreasonComponent);

BaseComponent revieweruser_column29Component = new BaseComponent {
Id = "Column29",
Type = "Column",
ParentId = "Column36",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"RelatedDocuments",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_column29Component);

BaseComponent revieweruser_requestdateComponent = new BaseComponent {
Id = "RequestDate",
Type = "DateTimePicker",
ParentId = "Column37",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RequestDate,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_requestdateComponent);

BaseComponent revieweruser_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
ParentId = "Column27",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Label1,
ViewProperties = "",
};

AddToViewItems("reviewerUser", revieweruser_label1Component);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            











Load += RequestEdit_OnLoad;






        }
    }
}