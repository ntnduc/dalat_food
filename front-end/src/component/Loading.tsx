import { Spin } from 'antd';
import React from 'react';

interface Props {
    style?: React.CSSProperties
}

const Loading = (props: Props) => {
    return (
        <div className='loading' style={props.style}>
            <Spin />
        </div>  
    );
};

export default Loading;