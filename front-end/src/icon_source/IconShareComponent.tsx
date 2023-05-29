import { IIconProps } from './IIconType';
import { ReactComponent as ShareComponent } from './share.svg';

const IconShareComponent = (props: IIconProps) => {
    return (<ShareComponent style={Object.assign({ width: 16, height: 16 }, props.style)} className={props.className} />);
};

export default IconShareComponent;
