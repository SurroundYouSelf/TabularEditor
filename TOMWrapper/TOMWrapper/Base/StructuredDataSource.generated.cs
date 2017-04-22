// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using TOM = Microsoft.AnalysisServices.Tabular;

namespace TabularEditor.TOMWrapper
{
  
    /// <summary>
	/// Base class declaration for StructuredDataSource
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class StructuredDataSource: DataSource
	{
	    protected internal new TOM.StructuredDataSource MetadataObject { get { return base.MetadataObject as TOM.StructuredDataSource; } internal set { base.MetadataObject = value; } }

		public StructuredDataSource(Model parent) : base(parent.Handler, new TOM.StructuredDataSource(), false) {
			MetadataObject.Name = parent.MetadataObject.DataSources.GetNewName("New StructuredDataSource");
			parent.DataSources.Add(this);
			Init();
		}

		public StructuredDataSource(TabularModelHandler handler, TOM.StructuredDataSource structureddatasourceMetadataObject) : base(handler, structureddatasourceMetadataObject)
		{
		}
        /// <summary>
        /// Gets or sets the ContextExpression of the StructuredDataSource.
        /// </summary>
		[DisplayName("Context Expression")]
		[Category("Other"),IntelliSense("The Context Expression of this StructuredDataSource.")][Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string ContextExpression {
			get {
			    return MetadataObject.ContextExpression;
			}
			set {
				var oldValue = ContextExpression;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("ContextExpression", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.ContextExpression = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "ContextExpression", oldValue, value));
				OnPropertyChanged("ContextExpression", oldValue, value);
			}
		}
		private bool ShouldSerializeContextExpression() { return false; }
    }
}