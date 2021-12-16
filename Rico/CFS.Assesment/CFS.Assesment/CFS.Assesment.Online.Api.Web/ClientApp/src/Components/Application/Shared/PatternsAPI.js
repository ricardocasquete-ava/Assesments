import Common from "../../Shared/Common";

const PatternsAPI = {

    getFee: async function (inputParameter, callbackMethod, callbackData, callbackErrorMethod) {
        Common.call("api/patterns/getFee", inputParameter, callbackMethod, callbackData, callbackErrorMethod);
    }
};

export default PatternsAPI;