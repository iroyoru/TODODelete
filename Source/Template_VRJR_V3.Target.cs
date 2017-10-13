// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Template_VRJR_V3Target : TargetRules
{
	public Template_VRJR_V3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Template_VRJR_V3" } );
	}
}
