import './style/dalat-button.scss';

import { Button } from 'antd';
import { FloatButtonGroupProps } from 'antd/es/float-button/interface';
import React from 'react';

const ButtonType = {
    normal: 'normal'
} as const;

type ObjValue<T> = T[keyof T];
type TypeButtonType = ObjValue<typeof ButtonType>

interface Props extends FloatButtonGroupProps {
    buttonType?: TypeButtonType
}

const normalClass = 'normal bg-[var(--main-color-green)] border-none text-white font-medium h-10 hover:opacity-[var(--main-bg-opacity)]';


const style: Record<TypeButtonType, React.ComponentProps<'div'>['className']> = {
    normal: `${normalClass}`,
};

const DaLatButton = (props: Props) => {
    const styleClass = props.buttonType ? style[props.buttonType] : style['normal'];
    return (
        <Button className={`dalat-button md:text-sm sm:text-xs ${styleClass} ${props.className}`} href={props.href}>{props.children}</Button>
    );
};

export default DaLatButton;
