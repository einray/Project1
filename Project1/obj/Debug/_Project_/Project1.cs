using Project1_Automation1 = Project1.Automation1;

using Project1_OCR = Project1.OCR;

using System;

namespace Project1.Project
{
// Project-8D59980627D961B
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D59980627D961B")]
[OpenSpan.Design.DeploymentVersionAttribute("1.1")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class Project1 : OpenSpan.Runtime.RuntimeProject
{
	
	public Project1() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Project1_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public Project1(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Project1_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public Project1(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Project1_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public Project1(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Project1_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private Project1(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Project1_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void Project1_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D59980627D961B");
		this.mVersion = new System.Version("8.0.1089.0");
		this.mDeploymentVersion = "1.1";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// Automator-8D599807A478460
	public Project1_Automation1 Automation1
	{
		get
		{
			return ((Project1_Automation1)(this["Automation1"]));
		}
	}
	
	// WindowsAdapter-8D5BF72AEBAE188
	public Project1_OCR OCR
	{
		get
		{
			return ((Project1_OCR)(this["OCR"]));
		}
	}
}

}

