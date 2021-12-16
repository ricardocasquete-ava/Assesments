//Declare Global Model
var consoleEnabled = false;
var consoleLevel = "Info";

var consoleConfigured = false;
var consoleBuffer = [];//Used to store the log messages prior to console being configured

//Common Helper Functions
//  -> Console
//  -> Data API
//  -> UI Helpers (Message, Confirm...)
const Common = {

    init: function () {

        if (!window.console) window.console = {};
        if (!window.console.log) window.console.log = function () { };
    },

    //#region Message Log

    setLog: function (logConfiguration) {
        consoleEnabled = logConfiguration.consoleEnabled;
        consoleLevel = logConfiguration.consoleLevel;

        if (consoleEnabled) {
            consoleBuffer.forEach(item => {
                Common.log(item.message, item.params);
            });
        }
        //Empty the buffer
        consoleBuffer = [];
    },

    log: function (message, params) {

        //While the console is being configured. Messages are stored in a temporal buffer
        if (!consoleConfigured) {
            consoleBuffer.push({ message: message, params: params });
        }

        if (consoleEnabled) {
            if ((params != null) && (params.length > 0)) {
                var i = params.length;
                while (i--) {
                    message = message.replace(new RegExp('\\{' + i + '\\}', 'gm'), params[i]);
                }
            }

            if (window.console && window.console.log) {
                if (consoleEnabled) {
                    window.console.log(message);
                }
            }
        }
    },

    handleError: function () {

    },

    //#endregion

    //#region Invoke Call 

    call: async function (url, requestParameter, callback, callbackData, callbackError) {

        Common.log("Common.Call URL -> {0}", [url]);
        Common.log(requestParameter);

        const response = await fetch(url, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            //body: requestParameter
            body: JSON.stringify(requestParameter)
        }).catch((err) => {
            Common.log("Common.Call Catch Error Block {0} -> ", [url]);
            Common.log(err);
        });

        const apiResponse = await response.json();

        Common.log("Common.Call API Response -> {0}", [url]);
        Common.log(apiResponse);

        if (apiResponse.isSuccessful === true) {

            if (callback != null) {
                callback(apiResponse.data, callbackData, apiResponse);
            } else {
                Common.log(callbackData);
                if ((callbackData) && (callbackData.successMessage)) {
                    Common.success(callbackData.successMessage);
                }
            }
        } else {
            Common.log("Common.Call Failed {0} -> ", [url]);

            if (apiResponse.errors != null) {
                var error;
                for (error in apiResponse.errors) {
                    if ((apiResponse.errors[error] != null) && (apiResponse.errors[error].length > 0)) {
                        Common.error(apiResponse.errors[error]);
                    } else {
                        Common.error(error);
                    }
                }
            } else {
                Common.error("Operation Failed. Reach Administrator for more information.");
            }

            if (callbackError != null) {
                Common.log("Common.Call Callback Error");
                callbackError(callbackData, apiResponse.data);
            }
        }
    },

    //#endregion

    //#region UI Messages

    success: function (message, title) {

        if (!title) {
            title = "";
        }

        //NotificationManager.success(message, title);
    },
    error: function (message, title) {

        if (!title) {
            title = "";
        }

        //NotificationManager.error(message, title);
    },

    //#endregion
}

export default Common;

