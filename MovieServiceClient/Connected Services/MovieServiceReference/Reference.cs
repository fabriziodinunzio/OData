﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieServiceClient.MovieServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieModelDTO", Namespace="http://schemas.datacontract.org/2004/07/MovieLibrary.DTO")]
    [System.SerializableAttribute()]
    public partial class MovieModelDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReviewModelDTO", Namespace="http://schemas.datacontract.org/2004/07/MovieLibrary.DTO")]
    [System.SerializableAttribute()]
    public partial class ReviewModelDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReviewTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReviewerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReviewText {
            get {
                return this.ReviewTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ReviewTextField, value) != true)) {
                    this.ReviewTextField = value;
                    this.RaisePropertyChanged("ReviewText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reviewer {
            get {
                return this.ReviewerField;
            }
            set {
                if ((object.ReferenceEquals(this.ReviewerField, value) != true)) {
                    this.ReviewerField = value;
                    this.RaisePropertyChanged("Reviewer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Review", Namespace="http://schemas.datacontract.org/2004/07/MovieLibrary")]
    [System.SerializableAttribute()]
    public partial class Review : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MovieServiceClient.MovieServiceReference.Movie MovieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReviewTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReviewerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieServiceClient.MovieServiceReference.Movie Movie {
            get {
                return this.MovieField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieField, value) != true)) {
                    this.MovieField = value;
                    this.RaisePropertyChanged("Movie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReviewText {
            get {
                return this.ReviewTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ReviewTextField, value) != true)) {
                    this.ReviewTextField = value;
                    this.RaisePropertyChanged("ReviewText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reviewer {
            get {
                return this.ReviewerField;
            }
            set {
                if ((object.ReferenceEquals(this.ReviewerField, value) != true)) {
                    this.ReviewerField = value;
                    this.RaisePropertyChanged("Reviewer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MovieLibrary")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MovieServiceClient.MovieServiceReference.Review[] ReviewsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieServiceClient.MovieServiceReference.Review[] Reviews {
            get {
                return this.ReviewsField;
            }
            set {
                if ((object.ReferenceEquals(this.ReviewsField, value) != true)) {
                    this.ReviewsField = value;
                    this.RaisePropertyChanged("Reviews");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieServiceReference.IMovieService")]
    public interface IMovieService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovies", ReplyAction="http://tempuri.org/IMovieService/GetMoviesResponse")]
        MovieServiceClient.MovieServiceReference.MovieModelDTO[] GetMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovies", ReplyAction="http://tempuri.org/IMovieService/GetMoviesResponse")]
        System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.MovieModelDTO[]> GetMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByTitle", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByTitleResponse")]
        MovieServiceClient.MovieServiceReference.MovieModelDTO[] GetMoviesByTitle(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByTitle", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByTitleResponse")]
        System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.MovieModelDTO[]> GetMoviesByTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovie", ReplyAction="http://tempuri.org/IMovieService/GetMovieResponse")]
        MovieServiceClient.MovieServiceReference.MovieModelDTO GetMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovie", ReplyAction="http://tempuri.org/IMovieService/GetMovieResponse")]
        System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.MovieModelDTO> GetMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetReviews", ReplyAction="http://tempuri.org/IMovieService/GetReviewsResponse")]
        MovieServiceClient.MovieServiceReference.ReviewModelDTO[] GetReviews(int movieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetReviews", ReplyAction="http://tempuri.org/IMovieService/GetReviewsResponse")]
        System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.ReviewModelDTO[]> GetReviewsAsync(int movieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/SubmitReview", ReplyAction="http://tempuri.org/IMovieService/SubmitReviewResponse")]
        void SubmitReview(int movieId, MovieServiceClient.MovieServiceReference.Review review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/SubmitReview", ReplyAction="http://tempuri.org/IMovieService/SubmitReviewResponse")]
        System.Threading.Tasks.Task SubmitReviewAsync(int movieId, MovieServiceClient.MovieServiceReference.Review review);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMovieServiceChannel : MovieServiceClient.MovieServiceReference.IMovieService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovieServiceClient : System.ServiceModel.ClientBase<MovieServiceClient.MovieServiceReference.IMovieService>, MovieServiceClient.MovieServiceReference.IMovieService {
        
        public MovieServiceClient() {
        }
        
        public MovieServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovieServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MovieServiceClient.MovieServiceReference.MovieModelDTO[] GetMovies() {
            return base.Channel.GetMovies();
        }
        
        public System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.MovieModelDTO[]> GetMoviesAsync() {
            return base.Channel.GetMoviesAsync();
        }
        
        public MovieServiceClient.MovieServiceReference.MovieModelDTO[] GetMoviesByTitle(string title) {
            return base.Channel.GetMoviesByTitle(title);
        }
        
        public System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.MovieModelDTO[]> GetMoviesByTitleAsync(string title) {
            return base.Channel.GetMoviesByTitleAsync(title);
        }
        
        public MovieServiceClient.MovieServiceReference.MovieModelDTO GetMovie(int id) {
            return base.Channel.GetMovie(id);
        }
        
        public System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.MovieModelDTO> GetMovieAsync(int id) {
            return base.Channel.GetMovieAsync(id);
        }
        
        public MovieServiceClient.MovieServiceReference.ReviewModelDTO[] GetReviews(int movieId) {
            return base.Channel.GetReviews(movieId);
        }
        
        public System.Threading.Tasks.Task<MovieServiceClient.MovieServiceReference.ReviewModelDTO[]> GetReviewsAsync(int movieId) {
            return base.Channel.GetReviewsAsync(movieId);
        }
        
        public void SubmitReview(int movieId, MovieServiceClient.MovieServiceReference.Review review) {
            base.Channel.SubmitReview(movieId, review);
        }
        
        public System.Threading.Tasks.Task SubmitReviewAsync(int movieId, MovieServiceClient.MovieServiceReference.Review review) {
            return base.Channel.SubmitReviewAsync(movieId, review);
        }
    }
}