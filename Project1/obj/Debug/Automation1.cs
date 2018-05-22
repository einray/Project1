using System;

namespace Project1
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// Automator-8D599807A478460
[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D599807A478460")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class Automation1 : OpenSpan.Automation.Automator
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D599807A478460\\EventLog-8D59980EF870AF6")]
	public System.Diagnostics.EventLog eventLog1;
	
	public Automation1()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(Automation1));
		this.eventLog1 = new System.Diagnostics.EventLog();
		((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("Automator-8D599807A478460");
		// 
		// Set component Ids
		// 
		this.SetId(this.eventLog1, new OpenSpan.Design.ComponentIdentity("EventLog-8D59980EF870AF6"));
		// 
		// Automation1
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("_Automation1_1_");
		this.IsStartStoppable = false;
		this.LogData = true;
		this.LogEvents = true;
		this.LogFile = "";
		this.LogToFile = false;
		this.Name = "Automation1";
		this.ShowDesignCompNames = true;
		this.SuppressErrors = false;
		// 
		// eventLog1
		// 
		this.SetScope(this.eventLog1, OpenSpan.Design.ConnectableScope.Local);
		// 
		// Initialize CodeDom data
		// 
		this.CodeDomData = _resources_.GetString("_Automation1_2_");
		((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.eventLog1);
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
	
	internal System.Diagnostics.EventLog Create_eventLog1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Diagnostics.EventLog eventLog1 = new System.Diagnostics.EventLog();
		this.SetId(eventLog1, new OpenSpan.Design.ComponentIdentity("EventLog-8D59980EF870AF6"));
		this.SetScope(eventLog1, OpenSpan.Design.ConnectableScope.Local);
		// 
		// Result
		// 
		return eventLog1;
	}
}

}

