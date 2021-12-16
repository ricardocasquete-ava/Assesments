import Common from "./Common";

const RefAPI = {

    //Generic Get Ref Data Methods
    get: async function (refKey, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/ref/{0}".format(refKey), {}, callbackMethod, callbackData, callbackErrorMethod);
    },

    getBatch: async function (refKeys, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/ref/getBatch", refKeys, callbackMethod, callbackData, callbackErrorMethod);
    },


    //Configuration and Session
    getSession: async function (callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/ref/getSession", {}, callbackMethod, callbackData, callbackErrorMethod);
    },

    setSession: async function (inputParameter, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/ref/setSession", inputParameter, callbackMethod, callbackData, callbackErrorMethod);
    },

    getConfig: async function (callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/ref/Config", {}, callbackMethod, callbackData, callbackErrorMethod);
    }
};

export default RefAPI;
