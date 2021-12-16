import Common from "../../Shared/Common";

const RoversAPI = {

    left: async function (inputParameter, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/rovers/left", inputParameter, callbackMethod, callbackData, callbackErrorMethod);
    },

    right: async function (inputParameter, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/rovers/right", inputParameter, callbackMethod, callbackData, callbackErrorMethod);
    },

    forward: async function (inputParameter, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/rovers/forward", inputParameter, callbackMethod, callbackData, callbackErrorMethod);
    },

    performMove: async function (inputParameter, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/rovers/moveOne", inputParameter, callbackMethod, callbackData, callbackErrorMethod);
    }
};

export default RoversAPI;