///
///     Autores: 
///             Quintana, Dario - uooopaa@gmail.com.ar - http://darionet.wordpress.com
///             Vicentin, Carlos - carlosvicentin@yahoo.com.ar - http://www.vicentis.com.ar
///             Insfran, Juan Carlos - juancainsfran@yahoo.com.ar
/// 


using System;
using System.Collections.Generic;

namespace GUI
{
	/// <summary>
	/// Es una estructura que se puede utilizar en ComboBox.Tiene un Valor y un Texto, de modo que el Texto se muestre en el Combo, y el valor por debajo es otro.
	/// </summary>
	public class ItemLista<V>
	{	
		private string _Text;
		private V _Value;
		
		public ItemLista()
		{
		}
		
		public ItemLista(string Texto,V Valor)
		{
			this._Text = Texto;
			this._Value = Valor;
		}
		

			
		public string Text
		{
			get{return _Text;}
			set{_Text = value;}
		}
		
		public V Value
		{
			get{return _Value;}
			set{_Value = value;}
		}
			
		public override string ToString()
		{
			return "Valor:"+this._Value+", Texto:"+this._Text;
		}
		
	}
}
