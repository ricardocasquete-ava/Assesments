import React, { useEffect, useState } from "react";
import Common from "../../Shared/Common";

const AppWrapper = (props) => {
    const [wrapClass, setWrapClass] = useState("");

    useEffect(() => {
        Common.log("Component Init -> /App Wrapper");
        setWrapClass(props.wrapperClass);

        Common.log(wrapClass);
    });

    return (
        <div className={wrapClass}>
            {props.children}
        </div>
    );
};

export default AppWrapper;
