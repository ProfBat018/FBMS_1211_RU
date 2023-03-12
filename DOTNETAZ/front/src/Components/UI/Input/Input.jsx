import React from 'react';

const Input = React.forwardRef((props, ref) => {
    return (
        <div>
            <input ref={ref} type="text"/>
        </div>
    );
});

export default Input;