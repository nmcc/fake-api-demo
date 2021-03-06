﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v11.16.1.0 (NJsonSchema v9.10.41.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace MovieRatingAPI.Fake
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.16.1.0 (NJsonSchema v9.10.41.0 (Newtonsoft.Json v9.0.0.0))")]
    public interface IMovieController
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<MovieEntry>> SearchAsync(string q);
    
        System.Threading.Tasks.Task<MovieData> GetAsync(string id);
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.16.1.0 (NJsonSchema v9.10.41.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class MovieController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IMovieController _implementation;
    
        public MovieController(IMovieController implementation)
        {
            _implementation = implementation;
        }
    
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/Movie/search")]
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MovieEntry>> Search(string q)
        {
            return _implementation.SearchAsync(q);
        }
    
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/Movie/{id}")]
        public System.Threading.Tasks.Task<MovieData> Get(string id)
        {
            return _implementation.GetAsync(id);
        }
    
    }
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.41.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MovieEntry : System.ComponentModel.INotifyPropertyChanged
    {
        private string _imdbID;
        private string _title;
        private string _year;
        private string _type;
        private string _poster;
    
        [Newtonsoft.Json.JsonProperty("imdbID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImdbID
        {
            get { return _imdbID; }
            set 
            {
                if (_imdbID != value)
                {
                    _imdbID = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title
        {
            get { return _title; }
            set 
            {
                if (_title != value)
                {
                    _title = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Year
        {
            get { return _year; }
            set 
            {
                if (_year != value)
                {
                    _year = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Poster", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Poster
        {
            get { return _poster; }
            set 
            {
                if (_poster != value)
                {
                    _poster = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static MovieEntry FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MovieEntry>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.41.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MovieData : System.ComponentModel.INotifyPropertyChanged
    {
        private string _imdbID;
        private string _title;
        private string _year;
        private string _director;
        private decimal _imdbRating;
        private string _poster;
    
        [Newtonsoft.Json.JsonProperty("imdbID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImdbID
        {
            get { return _imdbID; }
            set 
            {
                if (_imdbID != value)
                {
                    _imdbID = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title
        {
            get { return _title; }
            set 
            {
                if (_title != value)
                {
                    _title = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Year
        {
            get { return _year; }
            set 
            {
                if (_year != value)
                {
                    _year = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Director", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Director
        {
            get { return _director; }
            set 
            {
                if (_director != value)
                {
                    _director = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("imdbRating", Required = Newtonsoft.Json.Required.Always)]
        public decimal ImdbRating
        {
            get { return _imdbRating; }
            set 
            {
                if (_imdbRating != value)
                {
                    _imdbRating = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Poster", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Poster
        {
            get { return _poster; }
            set 
            {
                if (_poster != value)
                {
                    _poster = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static MovieData FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MovieData>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }

}