﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace KoganeEditorLib
{
	[Serializable]
	public sealed class CustomizableToolbarSettingsData
	{
		//==============================================================================
		// 変数(SerializeField)
		//==============================================================================
		[SerializeField] private string  m_commandName = null;
		[SerializeField] private string  m_buttonName  = null;
		[SerializeField] private Texture m_image       = null;
		[SerializeField] private int     m_width       = 0;

		//==============================================================================
		// プロパティ
		//==============================================================================
		public string  CommandName => m_commandName;
		public string  ButtonName  => m_buttonName;
		public Texture Image       => m_image;
		public int     Width       => m_width;
		public bool    IsValid     => !string.IsNullOrEmpty( m_commandName );
	}

	[CreateAssetMenu( menuName = "Customizable Toolbar Settings", order = 9999 )]
	public sealed class CustomizableToolbarSettings : ScriptableObject
	{
		//==============================================================================
		// 変数(SerializeField)
		//==============================================================================
		[SerializeField] private CustomizableToolbarSettingsData[] m_list = null;

		//==============================================================================
		// プロパティ
		//==============================================================================
		public IList<CustomizableToolbarSettingsData> List => m_list;
	}
}