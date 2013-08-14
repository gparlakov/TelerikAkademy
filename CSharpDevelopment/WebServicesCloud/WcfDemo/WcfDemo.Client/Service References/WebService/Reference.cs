﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDemo.Client.WebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.IDemoService")]
    public interface IDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetDayOfWeek", ReplyAction="http://tempuri.org/IDemoService/GetDayOfWeekResponse")]
        string GetDayOfWeek(System.DateTime value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetDayOfWeek", ReplyAction="http://tempuri.org/IDemoService/GetDayOfWeekResponse")]
        System.Threading.Tasks.Task<string> GetDayOfWeekAsync(System.DateTime value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetStringRepeatedCount", ReplyAction="http://tempuri.org/IDemoService/GetStringRepeatedCountResponse")]
        int GetStringRepeatedCount(string text, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetStringRepeatedCount", ReplyAction="http://tempuri.org/IDemoService/GetStringRepeatedCountResponse")]
        System.Threading.Tasks.Task<int> GetStringRepeatedCountAsync(string text, string search);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceChannel : WcfDemo.Client.WebService.IDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceClient : System.ServiceModel.ClientBase<WcfDemo.Client.WebService.IDemoService>, WcfDemo.Client.WebService.IDemoService {
        
        public DemoServiceClient() {
        }
        
        public DemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDayOfWeek(System.DateTime value) {
            return base.Channel.GetDayOfWeek(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDayOfWeekAsync(System.DateTime value) {
            return base.Channel.GetDayOfWeekAsync(value);
        }
        
        public int GetStringRepeatedCount(string text, string search) {
            return base.Channel.GetStringRepeatedCount(text, search);
        }
        
        public System.Threading.Tasks.Task<int> GetStringRepeatedCountAsync(string text, string search) {
            return base.Channel.GetStringRepeatedCountAsync(text, search);
        }
    }
}