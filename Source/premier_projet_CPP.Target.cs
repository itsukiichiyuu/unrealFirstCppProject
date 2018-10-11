// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class premier_projet_CPPTarget : TargetRules
{
	public premier_projet_CPPTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "premier_projet_CPP" } );
	}
}
