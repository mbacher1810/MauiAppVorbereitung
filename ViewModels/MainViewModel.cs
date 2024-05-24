
using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppVorbereitung.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiAppVorbereitung.ViewModels;

public partial class MainViewModel : ObservableObject
{

	private string _title = "Ihre Filmempfehlung für heute ...";

	public string Title
	{
		get { return _title; }
		set { SetProperty(ref _title, value); }
	}

	[ObservableProperty]
	private string _subtitle = string.Empty;

	[ObservableProperty]
	private Film? _selectedFilm = null;

	[ObservableProperty]
	ObservableCollection<Film> _films = new ObservableCollection<Film>();
}
