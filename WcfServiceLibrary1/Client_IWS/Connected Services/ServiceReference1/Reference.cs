﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_IWS.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBikeService")]
    public interface IBikeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/ListStation", ReplyAction="http://tempuri.org/IBikeService/ListStationResponse")]
        string[] ListStation(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/ListStation", ReplyAction="http://tempuri.org/IBikeService/ListStationResponse")]
        System.Threading.Tasks.Task<string[]> ListStationAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/AvailableBike", ReplyAction="http://tempuri.org/IBikeService/AvailableBikeResponse")]
        int AvailableBike(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/AvailableBike", ReplyAction="http://tempuri.org/IBikeService/AvailableBikeResponse")]
        System.Threading.Tasks.Task<int> AvailableBikeAsync(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/ListCity", ReplyAction="http://tempuri.org/IBikeService/ListCityResponse")]
        string[] ListCity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeService/ListCity", ReplyAction="http://tempuri.org/IBikeService/ListCityResponse")]
        System.Threading.Tasks.Task<string[]> ListCityAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBikeServiceChannel : Client_IWS.ServiceReference1.IBikeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BikeServiceClient : System.ServiceModel.ClientBase<Client_IWS.ServiceReference1.IBikeService>, Client_IWS.ServiceReference1.IBikeService {
        
        public BikeServiceClient() {
        }
        
        public BikeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BikeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BikeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BikeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListStation(string city) {
            return base.Channel.ListStation(city);
        }
        
        public System.Threading.Tasks.Task<string[]> ListStationAsync(string city) {
            return base.Channel.ListStationAsync(city);
        }
        
        public int AvailableBike(string city, string station) {
            return base.Channel.AvailableBike(city, station);
        }
        
        public System.Threading.Tasks.Task<int> AvailableBikeAsync(string city, string station) {
            return base.Channel.AvailableBikeAsync(city, station);
        }
        
        public string[] ListCity() {
            return base.Channel.ListCity();
        }
        
        public System.Threading.Tasks.Task<string[]> ListCityAsync() {
            return base.Channel.ListCityAsync();
        }
    }
}
