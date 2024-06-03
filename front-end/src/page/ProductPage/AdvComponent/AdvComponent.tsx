import './style/adv-component.scss';

import DaLatButton from 'component/DaLatButton';
import { CSSProperties } from 'react';


interface Props {
    backgroundImage: string,
    tabContent: string,
    title: string,
    description: string,
    urlMoreInfo?: string,
    textButton?: string,
    style?: CSSProperties
}
const AdvComponent = (props: Props) => {
    return (
        <a className='container-adv flex flex-col lg:py-12 lg:px-10 shadow-md'
            href={props.urlMoreInfo}
            style={{ backgroundImage: `url(${props.backgroundImage})`, backgroundSize: 'cover' }}>
            <div className='content-body-adv flex flex-col w-2/5'>
                <span className="tab-content xl:text-base text-black font-semibold mb-3 lg:text-sm md:text-xs sm:text-xs">
                    {props.tabContent}
                </span>
                <h1 className='text-black font-semibold xl:text-3xl leading-9 lg:text-xl md:text-lg sm:text-base'>
                    {props.title}
                </h1>
                <span className="description-content xl:text-sm text-gray-500 mt-5 font-medium lg:text-xs md:text-xs">{props.description}</span>
                <DaLatButton className='w-28 mt-5' href={props.urlMoreInfo}>Chi Tiết</DaLatButton>
            </div>
        </a>
    );
};

export default AdvComponent;
