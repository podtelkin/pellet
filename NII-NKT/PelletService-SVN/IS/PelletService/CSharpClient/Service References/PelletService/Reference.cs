﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.1
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSConsoleTest.PelletService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://pellet.ifmo.ru/", ConfigurationName="PelletService.PelletService")]
    public interface PelletService {
        
        // CODEGEN: Контракт генерации сообщений с именем sessionId из пространства имен  не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://pellet.ifmo.ru/PelletService/executeQueryRequest", ReplyAction="http://pellet.ifmo.ru/PelletService/executeQueryResponse")]
        WSConsoleTest.PelletService.executeQueryResponse executeQuery(WSConsoleTest.PelletService.executeQueryRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем return из пространства имен  не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://pellet.ifmo.ru/PelletService/createSessionRequest", ReplyAction="http://pellet.ifmo.ru/PelletService/createSessionResponse")]
        WSConsoleTest.PelletService.createSessionResponse createSession(WSConsoleTest.PelletService.createSessionRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем sessionId из пространства имен  не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://pellet.ifmo.ru/PelletService/addOWLModelRequest", ReplyAction="http://pellet.ifmo.ru/PelletService/addOWLModelResponse")]
        WSConsoleTest.PelletService.addOWLModelResponse addOWLModel(WSConsoleTest.PelletService.addOWLModelRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем sessionId из пространства имен  не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://pellet.ifmo.ru/PelletService/closeSessionRequest", ReplyAction="http://pellet.ifmo.ru/PelletService/closeSessionResponse")]
        WSConsoleTest.PelletService.closeSessionResponse closeSession(WSConsoleTest.PelletService.closeSessionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class executeQueryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="executeQuery", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.executeQueryRequestBody Body;
        
        public executeQueryRequest() {
        }
        
        public executeQueryRequest(WSConsoleTest.PelletService.executeQueryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class executeQueryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sessionId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sparql;
        
        public executeQueryRequestBody() {
        }
        
        public executeQueryRequestBody(string sessionId, string sparql) {
            this.sessionId = sessionId;
            this.sparql = sparql;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class executeQueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="executeQueryResponse", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.executeQueryResponseBody Body;
        
        public executeQueryResponse() {
        }
        
        public executeQueryResponse(WSConsoleTest.PelletService.executeQueryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class executeQueryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public executeQueryResponseBody() {
        }
        
        public executeQueryResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createSessionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createSession", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.createSessionRequestBody Body;
        
        public createSessionRequest() {
        }
        
        public createSessionRequest(WSConsoleTest.PelletService.createSessionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class createSessionRequestBody {
        
        public createSessionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createSessionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createSessionResponse", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.createSessionResponseBody Body;
        
        public createSessionResponse() {
        }
        
        public createSessionResponse(WSConsoleTest.PelletService.createSessionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class createSessionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public createSessionResponseBody() {
        }
        
        public createSessionResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addOWLModelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addOWLModel", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.addOWLModelRequestBody Body;
        
        public addOWLModelRequest() {
        }
        
        public addOWLModelRequest(WSConsoleTest.PelletService.addOWLModelRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class addOWLModelRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sessionId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string content;
        
        public addOWLModelRequestBody() {
        }
        
        public addOWLModelRequestBody(string sessionId, string content) {
            this.sessionId = sessionId;
            this.content = content;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addOWLModelResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addOWLModelResponse", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.addOWLModelResponseBody Body;
        
        public addOWLModelResponse() {
        }
        
        public addOWLModelResponse(WSConsoleTest.PelletService.addOWLModelResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class addOWLModelResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int @return;
        
        public addOWLModelResponseBody() {
        }
        
        public addOWLModelResponseBody(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class closeSessionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="closeSession", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.closeSessionRequestBody Body;
        
        public closeSessionRequest() {
        }
        
        public closeSessionRequest(WSConsoleTest.PelletService.closeSessionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class closeSessionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sessionId;
        
        public closeSessionRequestBody() {
        }
        
        public closeSessionRequestBody(string sessionId) {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class closeSessionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="closeSessionResponse", Namespace="http://pellet.ifmo.ru/", Order=0)]
        public WSConsoleTest.PelletService.closeSessionResponseBody Body;
        
        public closeSessionResponse() {
        }
        
        public closeSessionResponse(WSConsoleTest.PelletService.closeSessionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class closeSessionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int @return;
        
        public closeSessionResponseBody() {
        }
        
        public closeSessionResponseBody(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PelletServiceChannel : WSConsoleTest.PelletService.PelletService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PelletServiceClient : System.ServiceModel.ClientBase<WSConsoleTest.PelletService.PelletService>, WSConsoleTest.PelletService.PelletService {
        
        public PelletServiceClient() {
        }
        
        public PelletServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PelletServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PelletServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PelletServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSConsoleTest.PelletService.executeQueryResponse WSConsoleTest.PelletService.PelletService.executeQuery(WSConsoleTest.PelletService.executeQueryRequest request) {
            return base.Channel.executeQuery(request);
        }
        
        public string executeQuery(string sessionId, string sparql) {
            WSConsoleTest.PelletService.executeQueryRequest inValue = new WSConsoleTest.PelletService.executeQueryRequest();
            inValue.Body = new WSConsoleTest.PelletService.executeQueryRequestBody();
            inValue.Body.sessionId = sessionId;
            inValue.Body.sparql = sparql;
            WSConsoleTest.PelletService.executeQueryResponse retVal = ((WSConsoleTest.PelletService.PelletService)(this)).executeQuery(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSConsoleTest.PelletService.createSessionResponse WSConsoleTest.PelletService.PelletService.createSession(WSConsoleTest.PelletService.createSessionRequest request) {
            return base.Channel.createSession(request);
        }
        
        public string createSession() {
            WSConsoleTest.PelletService.createSessionRequest inValue = new WSConsoleTest.PelletService.createSessionRequest();
            inValue.Body = new WSConsoleTest.PelletService.createSessionRequestBody();
            WSConsoleTest.PelletService.createSessionResponse retVal = ((WSConsoleTest.PelletService.PelletService)(this)).createSession(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSConsoleTest.PelletService.addOWLModelResponse WSConsoleTest.PelletService.PelletService.addOWLModel(WSConsoleTest.PelletService.addOWLModelRequest request) {
            return base.Channel.addOWLModel(request);
        }
        
        public int addOWLModel(string sessionId, string content) {
            WSConsoleTest.PelletService.addOWLModelRequest inValue = new WSConsoleTest.PelletService.addOWLModelRequest();
            inValue.Body = new WSConsoleTest.PelletService.addOWLModelRequestBody();
            inValue.Body.sessionId = sessionId;
            inValue.Body.content = content;
            WSConsoleTest.PelletService.addOWLModelResponse retVal = ((WSConsoleTest.PelletService.PelletService)(this)).addOWLModel(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSConsoleTest.PelletService.closeSessionResponse WSConsoleTest.PelletService.PelletService.closeSession(WSConsoleTest.PelletService.closeSessionRequest request) {
            return base.Channel.closeSession(request);
        }
        
        public int closeSession(string sessionId) {
            WSConsoleTest.PelletService.closeSessionRequest inValue = new WSConsoleTest.PelletService.closeSessionRequest();
            inValue.Body = new WSConsoleTest.PelletService.closeSessionRequestBody();
            inValue.Body.sessionId = sessionId;
            WSConsoleTest.PelletService.closeSessionResponse retVal = ((WSConsoleTest.PelletService.PelletService)(this)).closeSession(inValue);
            return retVal.Body.@return;
        }
    }
}
