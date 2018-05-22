using System;

namespace Project1
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// WindowsAdapter-8D5BF72AEBAE188
[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D5BF72AEBAE188")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class OCR : OpenSpan.Adapters.Windows.WindowsAdapter
{
	
	public OCR()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D5BF72AEBAE188");
		// 
		// OCR
		// 
		this.AdvancedConfiguration = null;
		ComponentInfo.CodeDomData = @"OSVSXXgMAAL1Ty2rDQAz8lSVnYztt3NhgB9KUQOmhpQnJeR8yLNnVLvsg7N/XgT4wKW0OTdFBMNLMCCG1K6OtQcDwiL1ZtNtkgeyoitBNni3gxlLMl4LaAM7ne4nCHD/zOz4hxaJdeg+aqfQredT9Cj04QA7+XEF7bpySLCO7gS4NdrO8PEVGVlGF6KBDiMFRlZGXyJTkT5C25gDYsfmcVry6mza3Myjr5scJv/TrS/X7SrBmCoKXN6LmFVy2gX8z+lj19Q2tHcg0DBZrRzUcjTtcy3STfAD9V8dQfHeBDwmplvy8dGKspYIxch+lEmOoGL/TGw==";
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "OCR";
		this.Name = "OCR";
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.None;
		this.StartMyDayControls = null;
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
}

}

